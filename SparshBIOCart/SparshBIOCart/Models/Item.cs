using Newtonsoft.Json;
using System.Collections.Generic;

namespace SparshBIOCart.Models
{
    public class ProductList
    {
        [JsonProperty("product")]
        public List<Product> Products { get; set; }

    }
    public class Product
    {
        [JsonProperty("product_cat")]
        public string Category { get; set; }

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