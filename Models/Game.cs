using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int CategoryID { get; set; }
        public decimal Size { get; set; }
        public string Descript { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        public string Link { get; set; }
        public int Popularity { get; set; }

        public virtual Category Category { get; set; }

    }
    public class GameDBCtxt : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}