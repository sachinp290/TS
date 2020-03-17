using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace TS.Web.Helpers
{
    public class APIGetHelper<T> where T : class
    {
        public  static IEnumerable<T> Get(string baseURL, string url)
        {
            IEnumerable<T> items = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49755/api/");
                //HTTP GET
                var responseTask = client.GetAsync(url);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<T>>();
                    readTask.Wait();

                    items = readTask.Result;
                }
            }
            return items;
        }
    }
}