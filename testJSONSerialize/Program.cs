using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace testJSONSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertJSONToObject();
        }

        #region public const string JSON_DATA = "..."

        public const string JSON_DATA =
            @"[
{
      'product_title': 'Cherry Tomato',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/cherrt-tomato.jpg',
      'product_sku': '0',
      'product_id': '125',
      'product_price': '140.0000',
      'product_cat': 'Cherry Tomato'
    },
    {
      'product_title': 'Clean Up Detox Therapy',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/cleanup.jpg',
      'product_sku': '004',
      'product_id': '263',
      'product_price': '0',
      'product_cat': 'Food Supplements'
    },
    {
      'product_title': 'Diabetick',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/diabetick.jpg',
      'product_sku': '003',
      'product_id': '265',
      'product_price': '0',
      'product_cat': 'Food Supplements'
    },
    {
      'product_title': 'Forty On',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/fortyon.jpg',
      'product_sku': '002',
      'product_id': '267',
      'product_price': '0',
      'product_cat': 'Food Supplements'
    },
    {
      'product_title': 'Ginger Garlic Paste',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger-paste.jpg',
      'product_sku': '1',
      'product_id': '244',
      'product_price': '100',
      'product_cat': '0'
    },
    {
      'product_title': 'Ginger Garlic Paste',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger-paste.jpg',
      'product_sku': '2',
      'product_id': '243',
      'product_price': '200',
      'product_cat': '0'
    },
    {
      'product_title': 'Ginger Garlic Paste',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger-paste.jpg',
      'product_sku': '005',
      'product_id': '242',
      'product_price': '50.0000',
      'product_cat': 'Pickles'
    },
    {
      'product_title': 'Ginger Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger.jpg',
      'product_sku': '3',
      'product_id': '247',
      'product_price': '100',
      'product_cat': '0'
    },
    {
      'product_title': 'Ginger Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger.jpg',
      'product_sku': '4',
      'product_id': '246',
      'product_price': '200',
      'product_cat': '0'
    },
    {
      'product_title': 'Ginger Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/ginger.jpg',
      'product_sku': '008',
      'product_id': '241',
      'product_price': '100',
      'product_cat': 'Pickles'
    },
    {
      'product_title': 'Lime Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/lime.jpg',
      'product_sku': '5',
      'product_id': '250',
      'product_price': '100',
      'product_cat': '0'
    },
    {
      'product_title': 'Lime Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/lime.jpg',
      'product_sku': '6',
      'product_id': '249',
      'product_price': '200',
      'product_cat': '0'
    },
    {
      'product_title': 'Lime Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/lime.jpg',
      'product_sku': '009',
      'product_id': '240',
      'product_price': '100',
      'product_cat': 'Pickles'
    },
    {
      'product_title': 'Mango Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/mango.jpg',
      'product_sku': '007',
      'product_id': '237',
      'product_price': '100',
      'product_cat': 'Pickles'
    },
    {
      'product_title': 'Mango Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/mango.jpg',
      'product_sku': '9',
      'product_id': '254',
      'product_price': '100',
      'product_cat': '0'
    },
    {
      'product_title': 'Mango Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/mango.jpg',
      'product_sku': '10',
      'product_id': '253',
      'product_price': '300',
      'product_cat': '0'
    },
    {
      'product_title': 'Slim In',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/slimin.jpg',
      'product_sku': '001',
      'product_id': '268',
      'product_price': '0',
      'product_cat': 'Food Supplements'
    },
    {
      'product_title': 'Slim Pro',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/slimpro.jpg',
      'product_sku': '123',
      'product_id': '269',
      'product_price': '80.0000',
      'product_cat': 'Food Supplements'
    },
    {
      'product_title': 'Tomato Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/tomato.jpg',
      'product_sku': '7',
      'product_id': '252',
      'product_price': '100',
      'product_cat': '0'
    },
    {
      'product_title': 'Tomato Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/tomato.jpg',
      'product_sku': '8',
      'product_id': '251',
      'product_price': '200',
      'product_cat': '0'
    },
    {
      'product_title': 'Tomato Pickle',
      'product_url': 'http://sparshbiolife.com/wp-content/uploads/2016/08/tomato.jpg',
      'product_sku': '010',
      'product_id': '239',
      'product_price': '100',
      'product_cat': 'Pickles'
    }
    ]";

        #endregion public const string JSON_DATA = "..."

        private static void ConvertJSONToObject()
        {
            string url = "http://sparshbiolife.com/webservice/getproducts.php?user_id=2";
            RequestParams param = new RequestParams();
            // Program prg = new Program();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(url).Result;

                var items = JsonConvert.DeserializeObject<ProductList>(response.Content.ReadAsStringAsync().Result);
            }

         //   var items = JsonConvert.DeserializeObject<List<Product>>(strJSONDATA);

        }

        //static IEnumerable<Product> GetProducts()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Add("appkey", "myapp_key");

        //        var response = client.GetAsync("http://localhost:57163/api/foo").Result;

        //        if (response.IsSuccessStatusCode)
        //            return response.Content.ReadAsAsync<IEnumerable<Product>>().Result.ToList();
        //    }

        //    return null;
        //}
        //public  async  Task<string> getProductList(RequestParams param)
        //{
        //    string url = "http://sparshbiolife.com/webservice/getproducts.php?user_id=2";

        //    var client = new System.Net.Http.HttpClient();

        //    string json = JsonConvert.SerializeObject(param, Formatting.Indented);

        //    //client.BaseAddress = new Uri(BaseURL);
        //    client.DefaultRequestHeaders
        //        .Accept
        //        .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    Uri uri = new Uri(url);
        //    var response = await client.PostAsync(uri, new StringContent(json,
        //                       Encoding.UTF8,
        //                       "application/json"));

        //    response.EnsureSuccessStatusCode();

        //    var result = response.Content.ReadAsStringAsync().Result;
        //    return result;
        //}
    }
}
