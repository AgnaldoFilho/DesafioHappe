namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItensSideMenuMarkets", "Route", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItensSideMenuMarkets", "Route");
        }
    }
}
