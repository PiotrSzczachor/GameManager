namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnsToElements : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElementTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Alchemists", "Atributes", c => c.String());
            AddColumn("dbo.Alchemists", "Type_Id", c => c.Int());
            AddColumn("dbo.Archers", "Atributes", c => c.String());
            AddColumn("dbo.Archers", "Type_Id", c => c.Int());
            AddColumn("dbo.Bats", "Atributes", c => c.String());
            AddColumn("dbo.Bats", "Type_Id", c => c.Int());
            AddColumn("dbo.Cobras", "Atributes", c => c.String());
            AddColumn("dbo.Cobras", "Type_Id", c => c.Int());
            AddColumn("dbo.Dragons", "Atributes", c => c.String());
            AddColumn("dbo.Dragons", "Type_Id", c => c.Int());
            AddColumn("dbo.Ents", "Atributes", c => c.String());
            AddColumn("dbo.Ents", "Type_Id", c => c.Int());
            AddColumn("dbo.Golems", "Atributes", c => c.String());
            AddColumn("dbo.Golems", "Type_Id", c => c.Int());
            AddColumn("dbo.Knights", "Atributes", c => c.String());
            AddColumn("dbo.Knights", "Type_Id", c => c.Int());
            AddColumn("dbo.Mummies", "Atributes", c => c.String());
            AddColumn("dbo.Mummies", "Type_Id", c => c.Int());
            AddColumn("dbo.Scorpions", "Atributes", c => c.String());
            AddColumn("dbo.Scorpions", "Type_Id", c => c.Int());
            AddColumn("dbo.Spiders", "Atributes", c => c.String());
            AddColumn("dbo.Spiders", "Type_Id", c => c.Int());
            AddColumn("dbo.Warewolves", "Atributes", c => c.String());
            AddColumn("dbo.Warewolves", "Type_Id", c => c.Int());
            AddColumn("dbo.Warriors", "Atributes", c => c.String());
            AddColumn("dbo.Warriors", "Type_Id", c => c.Int());
            AddColumn("dbo.Witches", "Atributes", c => c.String());
            AddColumn("dbo.Witches", "Type_Id", c => c.Int());
            AddColumn("dbo.Wizzards", "Atributes", c => c.String());
            AddColumn("dbo.Wizzards", "Type_Id", c => c.Int());
            CreateIndex("dbo.Alchemists", "Type_Id");
            CreateIndex("dbo.Archers", "Type_Id");
            CreateIndex("dbo.Bats", "Type_Id");
            CreateIndex("dbo.Cobras", "Type_Id");
            CreateIndex("dbo.Dragons", "Type_Id");
            CreateIndex("dbo.Ents", "Type_Id");
            CreateIndex("dbo.Golems", "Type_Id");
            CreateIndex("dbo.Knights", "Type_Id");
            CreateIndex("dbo.Mummies", "Type_Id");
            CreateIndex("dbo.Scorpions", "Type_Id");
            CreateIndex("dbo.Spiders", "Type_Id");
            CreateIndex("dbo.Warewolves", "Type_Id");
            CreateIndex("dbo.Warriors", "Type_Id");
            CreateIndex("dbo.Witches", "Type_Id");
            CreateIndex("dbo.Wizzards", "Type_Id");
            AddForeignKey("dbo.Alchemists", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Archers", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Bats", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Cobras", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Dragons", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Ents", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Golems", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Knights", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Mummies", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Scorpions", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Spiders", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Warewolves", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Warriors", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Witches", "Type_Id", "dbo.ElementTypes", "Id");
            AddForeignKey("dbo.Wizzards", "Type_Id", "dbo.ElementTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wizzards", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Witches", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Warriors", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Warewolves", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Spiders", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Scorpions", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Mummies", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Knights", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Golems", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Ents", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Dragons", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Cobras", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Bats", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Archers", "Type_Id", "dbo.ElementTypes");
            DropForeignKey("dbo.Alchemists", "Type_Id", "dbo.ElementTypes");
            DropIndex("dbo.Wizzards", new[] { "Type_Id" });
            DropIndex("dbo.Witches", new[] { "Type_Id" });
            DropIndex("dbo.Warriors", new[] { "Type_Id" });
            DropIndex("dbo.Warewolves", new[] { "Type_Id" });
            DropIndex("dbo.Spiders", new[] { "Type_Id" });
            DropIndex("dbo.Scorpions", new[] { "Type_Id" });
            DropIndex("dbo.Mummies", new[] { "Type_Id" });
            DropIndex("dbo.Knights", new[] { "Type_Id" });
            DropIndex("dbo.Golems", new[] { "Type_Id" });
            DropIndex("dbo.Ents", new[] { "Type_Id" });
            DropIndex("dbo.Dragons", new[] { "Type_Id" });
            DropIndex("dbo.Cobras", new[] { "Type_Id" });
            DropIndex("dbo.Bats", new[] { "Type_Id" });
            DropIndex("dbo.Archers", new[] { "Type_Id" });
            DropIndex("dbo.Alchemists", new[] { "Type_Id" });
            DropColumn("dbo.Wizzards", "Type_Id");
            DropColumn("dbo.Wizzards", "Atributes");
            DropColumn("dbo.Witches", "Type_Id");
            DropColumn("dbo.Witches", "Atributes");
            DropColumn("dbo.Warriors", "Type_Id");
            DropColumn("dbo.Warriors", "Atributes");
            DropColumn("dbo.Warewolves", "Type_Id");
            DropColumn("dbo.Warewolves", "Atributes");
            DropColumn("dbo.Spiders", "Type_Id");
            DropColumn("dbo.Spiders", "Atributes");
            DropColumn("dbo.Scorpions", "Type_Id");
            DropColumn("dbo.Scorpions", "Atributes");
            DropColumn("dbo.Mummies", "Type_Id");
            DropColumn("dbo.Mummies", "Atributes");
            DropColumn("dbo.Knights", "Type_Id");
            DropColumn("dbo.Knights", "Atributes");
            DropColumn("dbo.Golems", "Type_Id");
            DropColumn("dbo.Golems", "Atributes");
            DropColumn("dbo.Ents", "Type_Id");
            DropColumn("dbo.Ents", "Atributes");
            DropColumn("dbo.Dragons", "Type_Id");
            DropColumn("dbo.Dragons", "Atributes");
            DropColumn("dbo.Cobras", "Type_Id");
            DropColumn("dbo.Cobras", "Atributes");
            DropColumn("dbo.Bats", "Type_Id");
            DropColumn("dbo.Bats", "Atributes");
            DropColumn("dbo.Archers", "Type_Id");
            DropColumn("dbo.Archers", "Atributes");
            DropColumn("dbo.Alchemists", "Type_Id");
            DropColumn("dbo.Alchemists", "Atributes");
            DropTable("dbo.ElementTypes");
        }
    }
}
