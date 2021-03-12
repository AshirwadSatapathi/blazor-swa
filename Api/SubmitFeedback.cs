using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure.AI.TextAnalytics;
using BlazorApp.Shared;
using System.Data.SqlClient;
using Azure;

namespace BlazorApp.Api
{
    public static class SubmitFeedback
    {
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential(Environment.GetEnvironmentVariable("key"));
        private static readonly Uri endpoint = new Uri(Environment.GetEnvironmentVariable("endpoint"));
        private static TextAnalyticsClient client = new TextAnalyticsClient(endpoint, credentials);

        [FunctionName("SubmitFeedback")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            Feedback data;
            int insertRecord;
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            try
            {
                data = JsonConvert.DeserializeObject<Feedback>(requestBody);
                data.FeedbackSentiment = GetFeedbackSentiment(data.StudentFeedback);

                insertRecord = InsertData(data);

                return new OkObjectResult(data);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }

        }
        public static string GetFeedbackSentiment(string feedback)
        {

            DocumentSentiment documentSentiment = client.AnalyzeSentiment(feedback);
            return documentSentiment.Sentiment.ToString();
        }
        public static int InsertData(Feedback feedback)
        {
            int recordsInserted;
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("connectionString")))
                {
                    string queryString = @"INSERT INTO [Feedback](StudentId,SubjectName,StudentFeedback,FeedbackSentiment)
                                       VALUES(@StudentId,@SubjectName,@StudentFeedback,@FeedbackSentiment)";

                    using (SqlCommand cmd = new SqlCommand(queryString))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", feedback.StudentId);
                        cmd.Parameters.AddWithValue("@SubjectName", feedback.SubjectName);
                        cmd.Parameters.AddWithValue("@StudentFeedback", feedback.StudentFeedback);
                        cmd.Parameters.AddWithValue("@FeedbackSentiment", feedback.FeedbackSentiment);
                        cmd.Connection = connection;
                        connection.Open();
                        recordsInserted = cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                recordsInserted = 0;
            }
            return recordsInserted;
        }
    }
}
