namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idset : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "customer_ID", c => c.Int());
            AddColumn("dbo.AspNetUsers", "worker_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "customer_ID");
            CreateIndex("dbo.AspNetUsers", "worker_ID");
            AddForeignKey("dbo.AspNetUsers", "customer_ID", "dbo.Customers", "ID");
            AddForeignKey("dbo.AspNetUsers", "worker_ID", "dbo.Workers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "worker_ID", "dbo.Workers");
            DropForeignKey("dbo.AspNetUsers", "customer_ID", "dbo.Customers");
            DropIndex("dbo.AspNetUsers", new[] { "worker_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "customer_ID" });
            DropColumn("dbo.AspNetUsers", "worker_ID");
            DropColumn("dbo.AspNetUsers", "customer_ID");
        }
    }
}
