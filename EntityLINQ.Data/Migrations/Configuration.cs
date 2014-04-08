namespace EntityLINQ.Data.Migrations
{
    using EntityLINQ.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityLINQ.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityLINQ.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Orders.AddOrUpdate(
            p => p.id,
            new Order { id = 1, Description = "Cake", OrderDate = DateTime.Now, OrderTotal = 15 },
            new Order { id = 2, Description = "Party and Cake", OrderDate = DateTime.Now, OrderTotal = 52 },
            new Order { id = 3, Description = "Party, Cake, Moonwalk", OrderDate = DateTime.Now, OrderTotal = 152 },
            new Order { id = 4, Description = "Cake", OrderDate = DateTime.Now, OrderTotal = 15 },
            new Order { id = 5, Description = "Party and Cake", OrderDate = DateTime.Now, OrderTotal = 52 },
            new Order { id = 6, Description = "Party, Cake, Moonwalk", OrderDate = DateTime.Now, OrderTotal = 152 },
            new Order { id = 7, Description = "Cake", OrderDate = DateTime.Now, OrderTotal = 15 },
            new Order { id = 8, Description = "Party and Cake", OrderDate = DateTime.Now, OrderTotal = 52 },
            new Order { id = 9, Description = "Party, Cake, Moonwalk", OrderDate = DateTime.Now, OrderTotal = 152 },
            new Order { id = 10, Description = "Party, Cake, Moonwalk", OrderDate = DateTime.Now, OrderTotal = 152 }
            );

            context.Customers.AddOrUpdate(
              p => p.id,
              new Customer { id = 1, Name = "Frank", Birthday = DateTime.Now },
              new Customer { id = 2, Name = "Sally", Birthday = DateTime.Now },
              new Customer { id = 3, Name = "Billy Bob", Birthday = DateTime.Now },
              new Customer { id = 4, Name = "Frank", Birthday = DateTime.Now },
              new Customer { id = 5, Name = "Sally", Birthday = DateTime.Now },
              new Customer { id = 6, Name = "Billy Bob", Birthday = DateTime.Now },
              new Customer { id = 7, Name = "Frank", Birthday = DateTime.Now },
              new Customer { id = 8, Name = "Sally", Birthday = DateTime.Now },
              new Customer { id = 9, Name = "Billy Bob", Birthday = DateTime.Now },
              new Customer { id = 10, Name = "Billy Bob", Birthday = DateTime.Now }
              );
        }
    }
}
