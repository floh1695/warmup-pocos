using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WarmUp_Pocos.Models
{
    public class Comment
    {
        public int ID { get; set; }

        //public int ParentCommentID { get; set; }
        //public Comment ParentComment { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}