using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Linq;

namespace SparshBIOCart.Services
{
   public class Service
    {
        private static string BaseURL;

        private async Task<string> Get(RequestParams param)
        {
            var client = new System.Net.Http.HttpClient();

            string json = JsonConvert.SerializeObject(param, Formatting.Indented);

            //client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Uri uri = new Uri(BaseURL);

            var response = await client.PostAsync(uri, new StringContent(json,
                               Encoding.UTF8,
                               "application/json"));

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;
            return result;
        }

    }
}
