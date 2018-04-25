using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarmUp_Pocos.Models
{
    public class Post
    {
        public int ID { get; set; }

        public int? UserID { get; set; }
        public User User { get; set; }

        public int? CategoryID { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}