using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string Descript { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

    }
}