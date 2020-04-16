using System;

namespace NetworkBlTypes
{
    public class AbuseReport : Report
    {
        public int NumReports { get; set; }
        public DateTime MostRecentReport { get; set; }
        public int AbuseConfidenceScore { get; set; }
    }
}