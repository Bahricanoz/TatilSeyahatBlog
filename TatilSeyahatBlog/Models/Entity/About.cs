using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatBlog.Models.Entity
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        public string Image { get; set; }
    }
}