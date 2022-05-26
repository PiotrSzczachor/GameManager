namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedRolesModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "AddElements", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditElements", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteElements", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "DeleteElements");
            DropColumn("dbo.Roles", "EditElements");
            DropColumn("dbo.Roles", "AddElements");
        }
    }
}
