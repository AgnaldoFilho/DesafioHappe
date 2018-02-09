namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelfRelationInItensMenu : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ItensSideMenuMarkets", "ParentId");
            AddForeignKey("dbo.ItensSideMenuMarkets", "ParentId", "dbo.ItensSideMenuMarkets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItensSideMenuMarkets", "ParentId", "dbo.ItensSideMenuMarkets");
            DropIndex("dbo.ItensSideMenuMarkets", new[] { "ParentId" });
        }
    }
}
