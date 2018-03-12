using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASfan.Models
{
    public class Team
    {
        public int id { get; set; }
        public string název { get; set; }
        public string kraj { get; set; }
        public string popis { get; set; }
        public bool nábor { get; set; }
        public string vůdce { get; set; }
    }
}