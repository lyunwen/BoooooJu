namespace BoooooJu.Web.Core.Dal.DBModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User_LoginRecord> User_LoginRecord { get; set; }
        public virtual DbSet<User_Statistics> User_Statistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
