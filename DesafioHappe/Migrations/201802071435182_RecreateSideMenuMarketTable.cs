namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateSideMenuMarketTable : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                    "dbo.ItensSideMenuMarket",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        ParentId = c.Int()
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.ItensSideMenuMarket");
        }
    }
}
