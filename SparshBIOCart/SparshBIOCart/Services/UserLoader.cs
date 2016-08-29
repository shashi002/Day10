using Newtonsoft.Json;
using SparshBIOCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public class UserLoader : IUserLoader
    {
        public async Task<User> getUserDetails(RequestParams param)
        {
            try
            {

                string url = "http://sparshbiolife.com/webservices_new/login.php?username=vijay123&pass=vijjuvijay";

                var client = new System.Net.Http.HttpClient();
                string json = JsonConvert.SerializeObject(param, Formatting.Indented);
                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Uri uri = new Uri(url);
                var response = await client.PostAsync(uri, new StringContent(json,
                                   Encoding.UTF8,
                                   "application/json"));
                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsStringAsync().Result;

                return null;
            }
            catch (Exception ex)
            {
                string str = ex.StackTrace.ToString();
                return null;
            }
        }
    }
}
