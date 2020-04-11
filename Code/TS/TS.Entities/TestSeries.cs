using System;

namespace TS.Entities
{
    public class TestSeries
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime GeneratedDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsReady { get; set; }

        public int TestConfigurationID { get; set; }

        public string TestConfigurationName { get; set; }
    }
}
