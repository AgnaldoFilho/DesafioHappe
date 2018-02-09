namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppUserIdAsFK : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.MenusForUsers", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.MenusForUsers", "ApplicationUserId");
            RenameColumn(table: "dbo.MenusForUsers", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            AlterColumn("dbo.MenusForUsers", "ApplicationUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.MenusForUsers", "ApplicationUserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.MenusForUsers", new[] { "ApplicationUserId" });
            AlterColumn("dbo.MenusForUsers", "ApplicationUserId", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.MenusForUsers", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            AddColumn("dbo.MenusForUsers", "ApplicationUserId", c => c.Guid(nullable: false));
            CreateIndex("dbo.MenusForUsers", "ApplicationUser_Id");
        }
    }
}
