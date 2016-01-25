using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace BoooooJu.Service.Core.Dal
{
    public partial class BoooooJuDB : DbContext
    {
        public BoooooJuDB()
            : base("name=BoooooJuDB")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
