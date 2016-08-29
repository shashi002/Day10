using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testJSONSerialize
{
    public class Product
    {
        public string product_title { get; set; }
        public string product_url { get; set; }
        public string product_sku { get; set; }
        public string product_id { get; set; }
        public string product_price { get; set; }
        public string product_cat { get; set; }
    }

    public class RootObject
    {
        public List<Product> product { get; set; }
    }
}
