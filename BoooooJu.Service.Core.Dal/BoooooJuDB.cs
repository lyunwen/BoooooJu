namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BoooooJuDB : DbContext
    {
        public BoooooJuDB()
            : base("name=BoooooJuDB")
        {
        }

        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<UerKey> UerKeys { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
