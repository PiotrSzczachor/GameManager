namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Castles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        material = c.String(),
                        towersNumber = c.Int(nullable: false),
                        buildYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Caves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        caveArea = c.Int(nullable: false),
                        caveName = c.String(),
                        caveDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        forestArea = c.Int(nullable: false),
                        forestName = c.String(),
                        forestType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forests");
            DropTable("dbo.Caves");
            DropTable("dbo.Castles");
        }
    }
}
