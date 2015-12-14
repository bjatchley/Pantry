namespace Pantry.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pantry.Data.Models;
    using Pantry.Data.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<Pantry.Data.Models.PantryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pantry.Data.Models.PantryContext context)
        {
            DbSeedHelper.SeedRecipeDatabase(context);
        }
    }
}
