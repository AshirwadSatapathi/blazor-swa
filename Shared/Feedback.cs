using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class Feedback
    {
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public string StudentFeedback { get; set; }
        public string FeedbackSentiment { get; set; }
    }
}
