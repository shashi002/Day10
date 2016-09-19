using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testJSONSerialize
{
   public class Product
    {


        [JsonProperty("product_cat")]
        public string Category { get; set; }

        [JsonProperty("product_description")]
        public string Description { get; set; }


        public string IconUrl { get; set; }

        [JsonProperty("product_url")]
        public string ImageUrl { get; set; }


        [JsonProperty("product_title")]
        public string Name { get; set; }

        [JsonProperty("product_price")]
        public double Price { get; set; }

        [JsonProperty("product_id")]
        public string ProductCode { get; set; }

        public int Rating { get; set; }

        public List<string> Tags { get; set; }

    }
}
