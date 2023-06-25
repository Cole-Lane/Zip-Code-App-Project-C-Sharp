using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Zip_Code_App_Project
{
    /// <summary>
    /// Helper class to start an API client for commuinication with the zippopotam.us API
    /// Sets the base address to the US
    /// </summary>
    public static class ApiHelper
    {
        //make it static to keep one client (port)
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://api.zippopotam.us/us/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            // except info in json format
            ApiClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
    }
}