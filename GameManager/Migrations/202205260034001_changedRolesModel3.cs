namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedRolesModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "AddForests", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddTemples", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddCastles", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddCaves", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddDeserts", c => c.Boolean(nullable: false));
            DropColumn("dbo.Roles", "AddCategories");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "AddCategories", c => c.Boolean(nullable: false));
            DropColumn("dbo.Roles", "AddDeserts");
            DropColumn("dbo.Roles", "AddCaves");
            DropColumn("dbo.Roles", "AddCastles");
            DropColumn("dbo.Roles", "AddTemples");
            DropColumn("dbo.Roles", "AddForests");
        }
    }
}
