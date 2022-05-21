namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoriesAndElements : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Castegories", newName: "Categories");
            CreateTable(
                "dbo.Alchemists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Healing = c.Int(nullable: false),
                        Inteligence = c.Int(nullable: false),
                        Support = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Temple_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Temples", t => t.Temple_Id)
                .Index(t => t.Temple_Id);
            
            CreateTable(
                "dbo.Temples",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        ChambersNumber = c.Int(nullable: false),
                        buildYear = c.Int(nullable: false),
                        Castegory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Castegory_Id)
                .Index(t => t.Castegory_Id);
            
            CreateTable(
                "dbo.Archers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Accuracy = c.Int(nullable: false),
                        Inteligence = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Focusing = c.Int(nullable: false),
                        Castle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.Castle_Id)
                .Index(t => t.Castle_Id);
            
            CreateTable(
                "dbo.Bats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Speed = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Hearing = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Cave_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Cobras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Virulence = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Shell = c.Int(nullable: false),
                        Seeing = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Desert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deserts", t => t.Desert_Id)
                .Index(t => t.Desert_Id);
            
            CreateTable(
                "dbo.Deserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        area = c.Int(nullable: false),
                        Castegory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Castegory_Id)
                .Index(t => t.Castegory_Id);
            
            CreateTable(
                "dbo.Dragons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Accuracy = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Cave_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Ents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Brave = c.Int(nullable: false),
                        Musculature = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Forest_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id)
                .Index(t => t.Forest_Id);
            
            CreateTable(
                "dbo.Golems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Brave = c.Int(nullable: false),
                        Musculature = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Cave_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Knights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Musculature = c.Int(nullable: false),
                        Brave = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Castle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.Castle_Id)
                .Index(t => t.Castle_Id);
            
            CreateTable(
                "dbo.Mummies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Desert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deserts", t => t.Desert_Id)
                .Index(t => t.Desert_Id);
            
            CreateTable(
                "dbo.Scorpions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Virulence = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Shell = c.Int(nullable: false),
                        Seeing = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Desert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deserts", t => t.Desert_Id)
                .Index(t => t.Desert_Id);
            
            CreateTable(
                "dbo.Spiders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Virulence = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Seeing = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Forest_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id)
                .Index(t => t.Forest_Id);
            
            CreateTable(
                "dbo.Warewolves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Brave = c.Int(nullable: false),
                        Musculature = c.Int(nullable: false),
                        Magica = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Forest_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id)
                .Index(t => t.Forest_Id);
            
            CreateTable(
                "dbo.Warriors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Musculature = c.Int(nullable: false),
                        Brave = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Castle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Castles", t => t.Castle_Id)
                .Index(t => t.Castle_Id);
            
            CreateTable(
                "dbo.Witches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Power = c.Int(nullable: false),
                        Inteligence = c.Int(nullable: false),
                        Energy = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Temple_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Temples", t => t.Temple_Id)
                .Index(t => t.Temple_Id);
            
            CreateTable(
                "dbo.Wizzards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Power = c.Int(nullable: false),
                        Inteligence = c.Int(nullable: false),
                        Energy = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Temple_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Temples", t => t.Temple_Id)
                .Index(t => t.Temple_Id);
            
            AddColumn("dbo.Castles", "name", c => c.String());
            DropColumn("dbo.Castles", "material");
            DropColumn("dbo.Forests", "forestType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forests", "forestType", c => c.String());
            AddColumn("dbo.Castles", "material", c => c.String());
            DropForeignKey("dbo.Wizzards", "Temple_Id", "dbo.Temples");
            DropForeignKey("dbo.Witches", "Temple_Id", "dbo.Temples");
            DropForeignKey("dbo.Warriors", "Castle_Id", "dbo.Castles");
            DropForeignKey("dbo.Warewolves", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Spiders", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Scorpions", "Desert_Id", "dbo.Deserts");
            DropForeignKey("dbo.Mummies", "Desert_Id", "dbo.Deserts");
            DropForeignKey("dbo.Knights", "Castle_Id", "dbo.Castles");
            DropForeignKey("dbo.Golems", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Ents", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Dragons", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Cobras", "Desert_Id", "dbo.Deserts");
            DropForeignKey("dbo.Deserts", "Castegory_Id", "dbo.Categories");
            DropForeignKey("dbo.Bats", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Archers", "Castle_Id", "dbo.Castles");
            DropForeignKey("dbo.Alchemists", "Temple_Id", "dbo.Temples");
            DropForeignKey("dbo.Temples", "Castegory_Id", "dbo.Categories");
            DropIndex("dbo.Wizzards", new[] { "Temple_Id" });
            DropIndex("dbo.Witches", new[] { "Temple_Id" });
            DropIndex("dbo.Warriors", new[] { "Castle_Id" });
            DropIndex("dbo.Warewolves", new[] { "Forest_Id" });
            DropIndex("dbo.Spiders", new[] { "Forest_Id" });
            DropIndex("dbo.Scorpions", new[] { "Desert_Id" });
            DropIndex("dbo.Mummies", new[] { "Desert_Id" });
            DropIndex("dbo.Knights", new[] { "Castle_Id" });
            DropIndex("dbo.Golems", new[] { "Cave_Id" });
            DropIndex("dbo.Ents", new[] { "Forest_Id" });
            DropIndex("dbo.Dragons", new[] { "Cave_Id" });
            DropIndex("dbo.Deserts", new[] { "Castegory_Id" });
            DropIndex("dbo.Cobras", new[] { "Desert_Id" });
            DropIndex("dbo.Bats", new[] { "Cave_Id" });
            DropIndex("dbo.Archers", new[] { "Castle_Id" });
            DropIndex("dbo.Temples", new[] { "Castegory_Id" });
            DropIndex("dbo.Alchemists", new[] { "Temple_Id" });
            DropColumn("dbo.Castles", "name");
            DropTable("dbo.Wizzards");
            DropTable("dbo.Witches");
            DropTable("dbo.Warriors");
            DropTable("dbo.Warewolves");
            DropTable("dbo.Spiders");
            DropTable("dbo.Scorpions");
            DropTable("dbo.Mummies");
            DropTable("dbo.Knights");
            DropTable("dbo.Golems");
            DropTable("dbo.Ents");
            DropTable("dbo.Dragons");
            DropTable("dbo.Deserts");
            DropTable("dbo.Cobras");
            DropTable("dbo.Bats");
            DropTable("dbo.Archers");
            DropTable("dbo.Temples");
            DropTable("dbo.Alchemists");
            RenameTable(name: "dbo.Categories", newName: "Castegories");
        }
    }
}
