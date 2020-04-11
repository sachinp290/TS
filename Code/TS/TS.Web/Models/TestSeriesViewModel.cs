using System;

namespace TS.Web.Models
{
    public class TestSeriesViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TestConfigurationID { get; set; }
        public string TestConfigurationName { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsReady { get; set; }
    }
}