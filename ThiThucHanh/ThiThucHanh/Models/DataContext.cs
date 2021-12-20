using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ThiThucHanh.Models;
namespace ThiThucHanh.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ThucHanh") { }

        public DbSet<List> Lists { get; set; }
        
    }
}