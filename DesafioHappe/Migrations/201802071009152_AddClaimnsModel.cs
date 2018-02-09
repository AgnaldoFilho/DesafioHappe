namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClaimnsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetClaims",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AspNetClaims");
        }
    }
}
