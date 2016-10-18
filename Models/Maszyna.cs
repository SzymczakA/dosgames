using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class Maszyna
    {
        public int numerKolejny { get; set; }
        public string nazwa { get; set; }
        public int rokProdukcji { get; set; }
    }


    public class MaszynaDBCtxt : DbContext
    {
        public DbSet<Maszyna> Maszyny { get; set; }
    }
}