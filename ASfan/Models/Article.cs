using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASfan.Models
{
    public class Article
    {
        public int id { get; set; }
        public string autor { get; set; }
        public DateTime datum { get; set; }
        [AllowHtml]
        public string text { get; set; }
    }
}