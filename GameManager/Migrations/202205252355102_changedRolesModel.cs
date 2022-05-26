namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedRolesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "AddCategories", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteCategories", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditCategories", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddRoles", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditRoles", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteRoles", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddUsers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteUsers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EdidUsers", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "EdidUsers");
            DropColumn("dbo.Roles", "DeleteUsers");
            DropColumn("dbo.Roles", "AddUsers");
            DropColumn("dbo.Roles", "DeleteRoles");
            DropColumn("dbo.Roles", "EditRoles");
            DropColumn("dbo.Roles", "AddRoles");
            DropColumn("dbo.Roles", "EditCategories");
            DropColumn("dbo.Roles", "DeleteCategories");
            DropColumn("dbo.Roles", "AddCategories");
        }
    }
}
