using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LearnTest0316.DAL
{
    public partial class MVCAchPOC_DB_DAL : DbContext
    {
        public MVCAchPOC_DB_DAL()
            : base("name=MVCAchPOC_DB_DAL")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
