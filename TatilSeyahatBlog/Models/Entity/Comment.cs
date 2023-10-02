using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatBlog.Models.Entity
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}