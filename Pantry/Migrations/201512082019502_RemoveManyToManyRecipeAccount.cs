namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveManyToManyRecipeAccount : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RecipeAccount", "Recipe_Id", "dbo.Recipe");
            DropForeignKey("dbo.RecipeAccount", "Account_Id", "dbo.Account");
            DropIndex("dbo.RecipeAccount", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeAccount", new[] { "Account_Id" });
            AddColumn("dbo.Recipe", "Account_Id", c => c.Int());
            CreateIndex("dbo.Recipe", "Account_Id");
            AddForeignKey("dbo.Recipe", "Account_Id", "dbo.Account", "Id");
            DropTable("dbo.RecipeAccount");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RecipeAccount",
                c => new
                    {
                        Recipe_Id = c.Int(nullable: false),
                        Account_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Recipe_Id, t.Account_Id });
            
            DropForeignKey("dbo.Recipe", "Account_Id", "dbo.Account");
            DropIndex("dbo.Recipe", new[] { "Account_Id" });
            DropColumn("dbo.Recipe", "Account_Id");
            CreateIndex("dbo.RecipeAccount", "Account_Id");
            CreateIndex("dbo.RecipeAccount", "Recipe_Id");
            AddForeignKey("dbo.RecipeAccount", "Account_Id", "dbo.Account", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RecipeAccount", "Recipe_Id", "dbo.Recipe", "Id", cascadeDelete: true);
        }
    }
}
