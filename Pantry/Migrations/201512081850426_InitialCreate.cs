namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountIngredient",
                c => new
                    {
                        AccountId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountId, t.IngredientId })
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Ingredient", t => t.IngredientId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.IngredientId);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecipeIngredient",
                c => new
                    {
                        RecipeId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RecipeId, t.IngredientId })
                .ForeignKey("dbo.Ingredient", t => t.IngredientId, cascadeDelete: true)
                .ForeignKey("dbo.Recipe", t => t.RecipeId, cascadeDelete: true)
                .Index(t => t.RecipeId)
                .Index(t => t.IngredientId);
            
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CaloriesPerGram = c.Double(nullable: false),
                        CaloriesPerMilliliter = c.Double(nullable: false),
                        Density = c.Double(nullable: false),
                        IsDry = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecipeAccount",
                c => new
                    {
                        Recipe_Id = c.Int(nullable: false),
                        Account_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Recipe_Id, t.Account_Id })
                .ForeignKey("dbo.Recipe", t => t.Recipe_Id, cascadeDelete: true)
                .ForeignKey("dbo.Account", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id)
                .Index(t => t.Account_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeIngredient", "RecipeId", "dbo.Recipe");
            DropForeignKey("dbo.RecipeIngredient", "IngredientId", "dbo.Ingredient");
            DropForeignKey("dbo.AccountIngredient", "IngredientId", "dbo.Ingredient");
            DropForeignKey("dbo.RecipeAccount", "Account_Id", "dbo.Account");
            DropForeignKey("dbo.RecipeAccount", "Recipe_Id", "dbo.Recipe");
            DropForeignKey("dbo.AccountIngredient", "AccountId", "dbo.Account");
            DropIndex("dbo.RecipeAccount", new[] { "Account_Id" });
            DropIndex("dbo.RecipeAccount", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeIngredient", new[] { "IngredientId" });
            DropIndex("dbo.RecipeIngredient", new[] { "RecipeId" });
            DropIndex("dbo.AccountIngredient", new[] { "IngredientId" });
            DropIndex("dbo.AccountIngredient", new[] { "AccountId" });
            DropTable("dbo.RecipeAccount");
            DropTable("dbo.Ingredient");
            DropTable("dbo.RecipeIngredient");
            DropTable("dbo.Recipe");
            DropTable("dbo.Account");
            DropTable("dbo.AccountIngredient");
        }
    }
}
