namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenusForUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenusForUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.Guid(nullable: false),
                        ItensSideMenuMarketId = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.ItensSideMenuMarkets", t => t.ItensSideMenuMarketId, cascadeDelete: true)
                .Index(t => t.ItensSideMenuMarketId)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.ItensSideMenuMarkets", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.ItensSideMenuMarkets", "ApplicationUser_Id");
            AddForeignKey("dbo.ItensSideMenuMarkets", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenusForUsers", "ItensSideMenuMarketId", "dbo.ItensSideMenuMarkets");
            DropForeignKey("dbo.MenusForUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ItensSideMenuMarkets", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.MenusForUsers", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.MenusForUsers", new[] { "ItensSideMenuMarketId" });
            DropIndex("dbo.ItensSideMenuMarkets", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.ItensSideMenuMarkets", "ApplicationUser_Id");
            DropTable("dbo.MenusForUsers");
        }
    }
}
