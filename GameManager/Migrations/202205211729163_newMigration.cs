namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Castegories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Castles", "Castegory_Id", c => c.Int());
            AddColumn("dbo.Caves", "Castegory_Id", c => c.Int());
            AddColumn("dbo.Forests", "Category_Id", c => c.Int());
            CreateIndex("dbo.Castles", "Castegory_Id");
            CreateIndex("dbo.Caves", "Castegory_Id");
            CreateIndex("dbo.Forests", "Category_Id");
            AddForeignKey("dbo.Castles", "Castegory_Id", "dbo.Castegories", "Id");
            AddForeignKey("dbo.Caves", "Castegory_Id", "dbo.Castegories", "Id");
            AddForeignKey("dbo.Forests", "Category_Id", "dbo.Castegories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Forests", "Category_Id", "dbo.Castegories");
            DropForeignKey("dbo.Caves", "Castegory_Id", "dbo.Castegories");
            DropForeignKey("dbo.Castles", "Castegory_Id", "dbo.Castegories");
            DropIndex("dbo.Forests", new[] { "Category_Id" });
            DropIndex("dbo.Caves", new[] { "Castegory_Id" });
            DropIndex("dbo.Castles", new[] { "Castegory_Id" });
            DropColumn("dbo.Forests", "Category_Id");
            DropColumn("dbo.Caves", "Castegory_Id");
            DropColumn("dbo.Castles", "Castegory_Id");
            DropTable("dbo.Castegories");
        }
    }
}
