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
        }
    }
}
