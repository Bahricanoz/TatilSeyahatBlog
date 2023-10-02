using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatBlog.Models.Entity
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}