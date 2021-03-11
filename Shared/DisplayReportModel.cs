using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class DisplayReportModel
    {
        public string SubjectName { get; set; }
        public int TotalPositiveFeedback { get; set; }
        public int TotalNegativeFeedback { get; set; }
        public int TotalNeutralFeedback { get; set; }
        public int TotalMixedFeedback { get; set; }
        public int TotalFeedbacks { get; set; }
    }
}
