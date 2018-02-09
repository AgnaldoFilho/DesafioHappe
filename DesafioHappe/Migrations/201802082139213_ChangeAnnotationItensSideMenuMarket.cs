namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnnotationItensSideMenuMarket : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItensSideMenuMarkets", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItensSideMenuMarkets", "Name", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
