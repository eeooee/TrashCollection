namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        zip_code_id = c.Int(nullable: false),
                        street_address_line1 = c.String(),
                        street_address_line2 = c.String(),
                        city_id = c.Int(nullable: false),
                        state_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ZipCodes", t => t.zip_code_id, cascadeDelete: true)
                .Index(t => t.zip_code_id);
            
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        zipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        vacation_id = c.Int(nullable: false),
                        address_id = c.Int(nullable: false),
                        pickup_id = c.Int(nullable: false),
                        fullName = c.String(),
                        nickName = c.String(),
                        accountBalance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.address_id, cascadeDelete: true)
                .ForeignKey("dbo.Pickups", t => t.pickup_id, cascadeDelete: true)
                .ForeignKey("dbo.Vacations", t => t.vacation_id, cascadeDelete: true)
                .Index(t => t.vacation_id)
                .Index(t => t.address_id)
                .Index(t => t.pickup_id);
            
            CreateTable(
                "dbo.Pickups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        daysOfWeek = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        on_vacation = c.Boolean(nullable: false),
                        returnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        zip_code_id = c.Int(nullable: false),
                        fullName = c.String(),
                        nickName = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ZipCodes", t => t.zip_code_id, cascadeDelete: true)
                .Index(t => t.zip_code_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "zip_code_id", "dbo.ZipCodes");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Customers", "vacation_id", "dbo.Vacations");
            DropForeignKey("dbo.Customers", "pickup_id", "dbo.Pickups");
            DropForeignKey("dbo.Customers", "address_id", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "zip_code_id", "dbo.ZipCodes");
            DropIndex("dbo.Workers", new[] { "zip_code_id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Customers", new[] { "pickup_id" });
            DropIndex("dbo.Customers", new[] { "address_id" });
            DropIndex("dbo.Customers", new[] { "vacation_id" });
            DropIndex("dbo.Addresses", new[] { "zip_code_id" });
            DropTable("dbo.Workers");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.States");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Vacations");
            DropTable("dbo.Pickups");
            DropTable("dbo.Customers");
            DropTable("dbo.Cities");
            DropTable("dbo.ZipCodes");
            DropTable("dbo.Addresses");
        }
    }
}
