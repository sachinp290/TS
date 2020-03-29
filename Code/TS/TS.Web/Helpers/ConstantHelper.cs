using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TS.Web.Helpers
{
    public class ConstantHelper
    {
        public static string BASEURL
        {
            get
            {
                return ConfigurationManager.AppSettings["BASEURL"];
            }
        }
    }
}