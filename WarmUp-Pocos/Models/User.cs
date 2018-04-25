using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarmUp_Pocos.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Username { get; set; }
        public DateTime Timestamp { get; set; }
        public int Karma { get; set; }
    }
}