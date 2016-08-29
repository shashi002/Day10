using Newtonsoft.Json;
using SparshBIOCart.Async;
using SparshBIOCart.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public class LoginService : ILoginService
    {
        private readonly ICache _cache;
        private  AsyncLazy<User> _userAsync;
        private readonly IUserLoader _loader;

        public LoginService(ICache cache)
        {
            _cache = cache;
            //_loader = loader;
        }

        public async Task<bool> IsLoggedIn()
        {
            var user = await _cache.GetObject<User>("LOGIN");
            return user != null;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            User userObject = null;
            try {
           
            RequestParams param = new RequestParams();
            param.Add("username",username);
            param.Add("password", password);

            string strJSONDATA = await getUserDetails(param);
            userObject = JsonConvert.DeserializeObject<User>(strJSONDATA);


            await _cache.InsertObject("LOGIN", userObject);
            }
            catch (Exception ex) {
                await _cache.InsertObject("LOGIN", userObject);
            }

            return userObject;
        }

        public async Task<string> getUserDetails(RequestParams param)
        {
            try
            {

                string url = String.Format("http://sparshbiolife.com/webservices_new/login.php?username={0}&pass={1}",param["username"], param["password"]);

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

                return result;
            }
            catch (Exception ex)
            {
                string str = ex.StackTrace.ToString();
                return null;
            }
        }
        private User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            if (username.Contains("fake")) return null;

            RequestParams param = new RequestParams();
            //  string strJSONDATA =  getUserDetails(param);

            //    return new User { Name = username, Password = password };

            return   new User { message = new Message { Name = username, Password = password } };
        }

        public async Task LogOutAsync()
        {
            await _cache.RemoveObject("LOGIN");
        }
    }
}