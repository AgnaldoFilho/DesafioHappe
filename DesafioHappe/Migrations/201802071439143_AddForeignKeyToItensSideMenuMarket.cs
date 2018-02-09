namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyToItensSideMenuMarket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItensSideMenuMarket", "ParentId", "dbo.ItensSideMenuMarket");
            DropIndex("dbo.ItensSideMenuMarket", new[] { "ParentId" });
            DropPrimaryKey("dbo.ItensSideMenuMarket");
            AddPrimaryKey("dbo.ItensSideMenuMarket", "Id");
            CreateIndex("dbo.ItensSideMenuMarket", "ParentId");
            AddForeignKey("dbo.ItensSideMenuMarket", "ParentId", "dbo.ItensSideMenuMarket", "Id");

        }

        public override void Down()
        {
            DropForeignKey("dbo.ItensSideMenuMarket", "ParentId", "dbo.ItensSideMenuMarket");
            DropIndex("dbo.ItensSideMenuMarket", new[] { "ParentId" });
            DropPrimaryKey("dbo.ItensSideMenuMarket");
            AddPrimaryKey("dbo.ItensSideMenuMarket", "Id");
            CreateIndex("dbo.ItensSideMenuMarket", "ParentId");
            AddForeignKey("dbo.ItensSideMenuMarket", "ParentId", "dbo.ItensSideMenuMarket", "Id");

        }
    }
}
