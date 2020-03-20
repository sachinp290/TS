using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TS.Web.Models;

namespace TS.Web.Helpers
{
    public class APIHelper<T> where T : class
    {
        public static IEnumerable<T> Get(string baseURL, string url)
        {
            IEnumerable<T> items = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
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

        public static T Get(string baseURL, string url, string querystring)
        {
            T item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                //HTTP GET
                var responseTask = client.GetAsync(url + "?" + querystring);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<T>();
                    readTask.Wait();

                    item = readTask.Result;
                }
            }
            return item;
        }

        public static bool Post(string baseURL, string url, T item)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<T>(url, item);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Delete(string baseURL, string url, int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);

                //HTTP Delete
                var deleteTask = client.DeleteAsync(url + "/" + id);
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}