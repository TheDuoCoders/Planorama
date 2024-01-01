namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.EMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.EMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 6; i++)
            {
                context.FoodsCategory.AddOrUpdate(new Models.FoodsCategory
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    UName = "User-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Type = "General"

                });
            }
        }
    }
}
