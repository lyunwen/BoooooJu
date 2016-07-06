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
        public virtual DbSet<DC_Food> DC_Food { get; set; }
        public virtual DbSet<DC_Order> DC_Order { get; set; }
        public virtual DbSet<DC_User> DC_User { get; set; }
        public virtual DbSet<Dynamic> Dynamics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserKey> UserKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
