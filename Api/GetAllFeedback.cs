using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using BlazorApp.Shared;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BlazorApp.Api
{
    public static class GetAllFeedback
    {
		[FunctionName("GetAllFeedback")]
		public static async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
			ILogger log)
		{
			List<FeedbackReport> data = new List<FeedbackReport>();
			string requestBody = await new StreamReader(req.Body).ReadToEndAsync();


			using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("connectionString")))
			{
				string oString = "select SubjectName,FeedbackSentiment FROM Feedback";
				SqlCommand oCmd = new SqlCommand(oString, connection);
				connection.Open();
				using (SqlDataReader oReader = oCmd.ExecuteReader())
				{
					while (oReader.Read())
					{
						FeedbackReport feedbackReport = new FeedbackReport();
						feedbackReport.SubjectName = oReader["SubjectName"].ToString();
						feedbackReport.FeedbackSentiment = oReader["FeedbackSentiment"].ToString();
						data.Add(feedbackReport);
					}

					connection.Close();
				}
			}

			return new OkObjectResult(data);
		}
	}
}
