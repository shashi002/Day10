using System;
using System.Linq;

namespace SparshBIOCart.Models
{
    public class User
    {
        public int status { get; set; }
        
        public Message message { get; set; }
    }
    public class Message
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string email { get; set; }
    }
}