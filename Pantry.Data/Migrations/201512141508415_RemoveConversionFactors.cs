namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveConversionFactors : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ingredient", "CaloriesPerGram");
            DropColumn("dbo.Ingredient", "CaloriesPerMilliliter");
            DropColumn("dbo.Ingredient", "Density");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredient", "Density", c => c.Double(nullable: false));
            AddColumn("dbo.Ingredient", "CaloriesPerMilliliter", c => c.Double(nullable: false));
            AddColumn("dbo.Ingredient", "CaloriesPerGram", c => c.Double(nullable: false));
        }
    }
}
