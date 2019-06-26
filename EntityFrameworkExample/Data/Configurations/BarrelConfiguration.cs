using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Data.Configurations
{
    public class BarrelConfiguration : EntityTypeConfiguration<Barrel>
    {
        public BarrelConfiguration()
        {
            HasKey(b => b.Id);
        }
    }
}