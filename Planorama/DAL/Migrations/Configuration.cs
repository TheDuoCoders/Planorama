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
                context.FoodsCategories.AddOrUpdate(new Models.FoodsCategory
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0,15),
                    Description = Guid.NewGuid().ToString().Substring(0, 20),

                }) ;
            }

            for (int i = 1; i <= 6; i++)
            {
                context.DecorationsCategories.AddOrUpdate(new Models.DecorationsCategory
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Description = Guid.NewGuid().ToString().Substring(0, 20),

                });
            }

            for (int i = 1; i <= 6; i++)
            {
                context.LocationsCategories.AddOrUpdate(new Models.LocationsCategory
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Description = Guid.NewGuid().ToString().Substring(0, 20),

                });
            }

            //-----------------------------------------------------------


            DateTime currentDate = DateTime.Now;
            Random random = new Random();
            int randomAge = random.Next(18, 51);

            for (int i = 1; i <= 6; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Uname = "User-" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Password = Guid.NewGuid().ToString().Substring(0, 15),
                    DOB = currentDate.AddYears(-randomAge),
                    Phone = Guid.NewGuid().ToString().Substring(0, 11),
                    Address = Guid.NewGuid().ToString().Substring(0, 20),
                    Points = 0,
                    UserType = "General",

                });
            }
        }
    }
}
