namespace BoooooJu.Service.Core.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoooooJuDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Id, t.Name });
            
            CreateTable(
                "BoooooJu.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 20),
                        Signature = c.String(maxLength: 100),
                        NickName = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 20),
                        PasswordSalt = c.String(nullable: false),
                        PasswordSaltType = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        CellPhoneValidate = c.Boolean(nullable: false),
                        CellPhone = c.String(),
                        EmailValidate = c.Boolean(nullable: false),
                        EmailAdress = c.String(maxLength: 20),
                        LastLoginIp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("BoooooJu.User");
            DropTable("dbo.Test");
        }
    }
}
