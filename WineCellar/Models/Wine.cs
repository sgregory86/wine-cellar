using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WineCellar.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grapes { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Year { get; set; }
    }
}