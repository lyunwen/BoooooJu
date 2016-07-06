namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<CICRole> CICRoles { get; set; }
        public virtual DbSet<CICUser> CICUsers { get; set; }
        public virtual DbSet<CICUserRole> CICUserRoles { get; set; }
        public virtual DbSet<Classify> Classifies { get; set; }
        public virtual DbSet<DC_Food> DC_Food { get; set; }
        public virtual DbSet<DC_Order> DC_Order { get; set; }
        public virtual DbSet<DC_User> DC_User { get; set; }
        public virtual DbSet<Dynamic> Dynamics { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Goods_Count> Goods_Count { get; set; }
        public virtual DbSet<Goods_Size> Goods_Size { get; set; }
        public virtual DbSet<Goods_Style> Goods_Style { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Store> User_Store { get; set; }
        public virtual DbSet<UserKey> UserKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CICRole>()
                .HasMany(e => e.CICUserRoles)
                .WithRequired(e => e.CICRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CICUser>()
                .HasMany(e => e.CICUserRoles)
                .WithRequired(e => e.CICUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DC_Food>()
                .HasMany(e => e.DC_Order)
                .WithRequired(e => e.DC_Food)
                .HasForeignKey(e => e.FoodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DC_User>()
                .HasMany(e => e.DC_Order)
                .WithRequired(e => e.DC_User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Good>()
                .Property(e => e.Price)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Goods_Size)
                .WithRequired(e => e.Good)
                .HasForeignKey(e => e.GoodsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Goods_Style)
                .WithRequired(e => e.Good)
                .HasForeignKey(e => e.GoodsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goods_Size>()
                .HasMany(e => e.Goods_Count)
                .WithRequired(e => e.Goods_Size)
                .HasForeignKey(e => e.GoodsSizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goods_Style>()
                .HasMany(e => e.Goods_Count)
                .WithRequired(e => e.Goods_Style)
                .HasForeignKey(e => e.GoodsStyleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserKeys)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserKey>()
                .Property(e => e.Token)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
