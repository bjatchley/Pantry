namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<PantryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PantryContext context)
        {
            DbSeedHelper.SeedRecipeDatabase(context);
        }
    }
}
