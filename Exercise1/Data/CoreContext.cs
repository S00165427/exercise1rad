using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Exercise1.Data
{
    public class CoreContext : DbContext
    {
        private object modelBuilder;

        public DbSet<User> Users { get; set; }

        public CoreContext()
            :base("CoreContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}