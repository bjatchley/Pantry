namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAmountToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AccountIngredient", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RecipeIngredient", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RecipeIngredient", "Amount", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountIngredient", "Amount", c => c.Int(nullable: false));
        }
    }
}
