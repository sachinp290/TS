﻿using System;

namespace TS.Entities
{
    public class Test
    {
        public int ID { get; set; }
        public int TestConfigurationID { get; set; }
        public string TestConfigurationName { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsReady { get; set; }
    }
}
