namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountIDtoRecipe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipe", "Account_Id", "dbo.Account");
            DropIndex("dbo.Recipe", new[] { "Account_Id" });
            RenameColumn(table: "dbo.Recipe", name: "Account_Id", newName: "AccountId");
            AlterColumn("dbo.Recipe", "AccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.Recipe", "AccountId");
            AddForeignKey("dbo.Recipe", "AccountId", "dbo.Account", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipe", "AccountId", "dbo.Account");
            DropIndex("dbo.Recipe", new[] { "AccountId" });
            AlterColumn("dbo.Recipe", "AccountId", c => c.Int());
            RenameColumn(table: "dbo.Recipe", name: "AccountId", newName: "Account_Id");
            CreateIndex("dbo.Recipe", "Account_Id");
            AddForeignKey("dbo.Recipe", "Account_Id", "dbo.Account", "Id");
        }
    }
}
