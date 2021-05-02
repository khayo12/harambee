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
    }
}