using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatBlog.Models.Entity
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Kullaniciadi { get; set; }
        public string Sifre { get; set; }
    }
}