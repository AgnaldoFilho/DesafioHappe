namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableNameAndAddParentIdColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItensSideMenuMarkets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        ParentId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.AspNetClaims");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AspNetClaims",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ItensSideMenuMarkets");
        }
    }
}
