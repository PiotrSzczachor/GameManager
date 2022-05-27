namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cascade2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
