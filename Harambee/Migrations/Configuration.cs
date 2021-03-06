namespace Harambee.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Harambee.Models.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Harambee.Models.Context.DatabaseContext";
        }

        protected override void Seed(Harambee.Models.Context.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(c => c.Id,
                new Models.Customer { Name = "Lucky", Surname = "July", Address = "2 Church Street, Sandton" },
                new Models.Customer { Name = "Zama", Surname = "Zulu", Address = "23 Main Street, Melville" }
                );

            context.Categorys.AddOrUpdate(c => c.Id,
                new Models.Category { Name = "TV", Description = "TV" },
                new Models.Category { Name = "Radio", Description = "Radio" },
                new Models.Category { Name = "Camera", Description = "Camera" }
                );

            context.Products.AddOrUpdate(c => c.Id,
                new Models.Product { Name = "LG TV", Description = "40 inch", Model = "2020", Price = 10000.00, CategoryId = 1 },
                new Models.Product { Name = "LG Radio", Description = "5 channel", Model = "2021", Price = 6000.00, CategoryId = 2 },
                new Models.Product { Name = "LG Camera", Description = "DSD", Model = "2020", Price = 7000.00, CategoryId = 3 },
                new Models.Product { Name = "Apple TV", Description = "40 inch", Model = "2020", Price = 21000.00, CategoryId = 1 }
                );

            context.Bundles.AddOrUpdate(c => c.Id,
                new Models.Bundle { Name = "Lounge", Description = "Lounge", ProductIds = new System.Collections.Generic.List<int>() { 1, 2 } }
                );

            context.Baskets.AddOrUpdate(c => c.Id,
                new Models.Basket { CustomerId = 1, ProductId = 1, Quantity = 2, Discount = false },
                new Models.Basket { CustomerId = 1, ProductId = 2, Quantity = 1, Discount = true }
                );
        }
    }
}
