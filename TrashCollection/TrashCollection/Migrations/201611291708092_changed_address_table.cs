namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_address_table : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Addresses", "state_id");
            AddForeignKey("dbo.Addresses", "state_id", "dbo.States", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "state_id", "dbo.States");
            DropIndex("dbo.Addresses", new[] { "state_id" });
        }
    }
}
