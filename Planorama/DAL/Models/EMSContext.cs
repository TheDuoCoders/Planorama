using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class EMSContext : DbContext
    {
        public DbSet<FoodsCategory> FoodsCategories { get; set;}
        public DbSet<Food> Foods { get; set;}
        public DbSet<DecorationsCategory> DecorationsCategories {  get; set;}
        public DbSet<Decoration> Decorations { get; set; }
        public DbSet<LocationsCategory> LocationsCategories { get; set; }
        public DbSet<Location> Locations { get; set; }






    }
}
