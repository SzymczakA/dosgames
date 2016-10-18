using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryEN { get; set; }
        public string CategoryPL { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }


}