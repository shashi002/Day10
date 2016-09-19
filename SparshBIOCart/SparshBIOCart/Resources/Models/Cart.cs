//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshBIOCart.Models
{
    class Cart
    {
        public int TotalItems { get; set; }


        public List<Product> CartItems { get; set; }
  
    }
}
