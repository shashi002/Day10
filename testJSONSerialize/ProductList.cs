using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testJSONSerialize
{
    public class ProductList
    {
        [JsonProperty("product")]
        public List<Product> Products { get; set; }

    }
}
