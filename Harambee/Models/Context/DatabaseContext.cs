using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Harambee.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbConnection") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bundle> Bundles { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}