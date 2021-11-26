using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2010A_WAD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductNAme { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }


        public virtual Category Category { get; set; }
    }
}