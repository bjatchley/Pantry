namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasUniqueAmountBaseType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredient", "HasUniqueBaseAmountType", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ingredient", "HasUniqueBaseAmountType");
        }
    }
}
