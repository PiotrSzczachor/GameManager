namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTablesCascade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alchemists", "Category_Id", "dbo.Temples");
            DropForeignKey("dbo.Archers", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Bats", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Cobras", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Dragons", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Ents", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Golems", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Knights", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Mummies", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Scorpions", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Spiders", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Warewolves", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Warriors", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Witches", "Category_Id", "dbo.Temples");
            DropForeignKey("dbo.Wizzards", "Category_Id", "dbo.Temples");
            AddForeignKey("dbo.Alchemists", "Category_Id", "dbo.Temples", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Archers", "Category_Id", "dbo.Castles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bats", "Category_Id", "dbo.Caves", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cobras", "Category_Id", "dbo.Deserts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dragons", "Category_Id", "dbo.Caves", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ents", "Category_Id", "dbo.Forests", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Golems", "Category_Id", "dbo.Caves", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Knights", "Category_Id", "dbo.Castles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Mummies", "Category_Id", "dbo.Deserts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Scorpions", "Category_Id", "dbo.Deserts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Spiders", "Category_Id", "dbo.Forests", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Warewolves", "Category_Id", "dbo.Forests", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Warriors", "Category_Id", "dbo.Castles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Witches", "Category_Id", "dbo.Temples", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Wizzards", "Category_Id", "dbo.Temples", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wizzards", "Category_Id", "dbo.Temples");
            DropForeignKey("dbo.Witches", "Category_Id", "dbo.Temples");
            DropForeignKey("dbo.Warriors", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Warewolves", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Spiders", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Scorpions", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Mummies", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Knights", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Golems", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Ents", "Category_Id", "dbo.Forests");
            DropForeignKey("dbo.Dragons", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Cobras", "Category_Id", "dbo.Deserts");
            DropForeignKey("dbo.Bats", "Category_Id", "dbo.Caves");
            DropForeignKey("dbo.Archers", "Category_Id", "dbo.Castles");
            DropForeignKey("dbo.Alchemists", "Category_Id", "dbo.Temples");
            AddForeignKey("dbo.Wizzards", "Category_Id", "dbo.Temples", "Id");
            AddForeignKey("dbo.Witches", "Category_Id", "dbo.Temples", "Id");
            AddForeignKey("dbo.Warriors", "Category_Id", "dbo.Castles", "Id");
            AddForeignKey("dbo.Warewolves", "Category_Id", "dbo.Forests", "Id");
            AddForeignKey("dbo.Spiders", "Category_Id", "dbo.Forests", "Id");
            AddForeignKey("dbo.Scorpions", "Category_Id", "dbo.Deserts", "Id");
            AddForeignKey("dbo.Mummies", "Category_Id", "dbo.Deserts", "Id");
            AddForeignKey("dbo.Knights", "Category_Id", "dbo.Castles", "Id");
            AddForeignKey("dbo.Golems", "Category_Id", "dbo.Caves", "Id");
            AddForeignKey("dbo.Ents", "Category_Id", "dbo.Forests", "Id");
            AddForeignKey("dbo.Dragons", "Category_Id", "dbo.Caves", "Id");
            AddForeignKey("dbo.Cobras", "Category_Id", "dbo.Deserts", "Id");
            AddForeignKey("dbo.Bats", "Category_Id", "dbo.Caves", "Id");
            AddForeignKey("dbo.Archers", "Category_Id", "dbo.Castles", "Id");
            AddForeignKey("dbo.Alchemists", "Category_Id", "dbo.Temples", "Id");
        }
    }
}
