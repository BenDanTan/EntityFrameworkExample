using EntityFrameworkExample.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Data.Context
{
    public class DataContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Tell the context about the configurations
            modelBuilder.Configurations.Add(new ExampleEntityConfiguration());
            modelBuilder.Configurations.Add(new ExampleChildEntityConfiguration());
            modelBuilder.Configurations.Add(new BarrelConfiguration());
        }
        public DbSet<Barrel> Barrels { get; set; }
    }
}