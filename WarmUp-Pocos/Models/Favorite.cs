using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WarmUp_Pocos.Models
{
    public class Favorite
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}