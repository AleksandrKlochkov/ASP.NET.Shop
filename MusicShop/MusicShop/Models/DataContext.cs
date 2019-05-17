using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicShop
{
    public class DataContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}