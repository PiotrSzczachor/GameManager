namespace GameManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ElementTypes", "Atributes", c => c.String());
            DropColumn("dbo.Alchemists", "Atributes");
            DropColumn("dbo.Archers", "Atributes");
            DropColumn("dbo.Bats", "Atributes");
            DropColumn("dbo.Cobras", "Atributes");
            DropColumn("dbo.Dragons", "Atributes");
            DropColumn("dbo.Ents", "Atributes");
            DropColumn("dbo.Golems", "Atributes");
            DropColumn("dbo.Knights", "Atributes");
            DropColumn("dbo.Mummies", "Atributes");
            DropColumn("dbo.Scorpions", "Atributes");
            DropColumn("dbo.Spiders", "Atributes");
            DropColumn("dbo.Warewolves", "Atributes");
            DropColumn("dbo.Warriors", "Atributes");
            DropColumn("dbo.Witches", "Atributes");
            DropColumn("dbo.Wizzards", "Atributes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Wizzards", "Atributes", c => c.String());
            AddColumn("dbo.Witches", "Atributes", c => c.String());
            AddColumn("dbo.Warriors", "Atributes", c => c.String());
            AddColumn("dbo.Warewolves", "Atributes", c => c.String());
            AddColumn("dbo.Spiders", "Atributes", c => c.String());
            AddColumn("dbo.Scorpions", "Atributes", c => c.String());
            AddColumn("dbo.Mummies", "Atributes", c => c.String());
            AddColumn("dbo.Knights", "Atributes", c => c.String());
            AddColumn("dbo.Golems", "Atributes", c => c.String());
            AddColumn("dbo.Ents", "Atributes", c => c.String());
            AddColumn("dbo.Dragons", "Atributes", c => c.String());
            AddColumn("dbo.Cobras", "Atributes", c => c.String());
            AddColumn("dbo.Bats", "Atributes", c => c.String());
            AddColumn("dbo.Archers", "Atributes", c => c.String());
            AddColumn("dbo.Alchemists", "Atributes", c => c.String());
            DropColumn("dbo.ElementTypes", "Atributes");
        }
    }
}
