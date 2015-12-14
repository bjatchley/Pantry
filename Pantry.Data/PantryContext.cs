namespace Pantry.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Data;

    public class PantryContext : DbContext
    {
        public DbSet<Models.Account> AccountSet { get; set; }
        public DbSet<Models.Ingredient> IngredientSet { get; set; }
        public DbSet<Models.Recipe> RecipeSet { get; set; }
        public DbSet<Models.AccountIngredient> AccountIngredientSet { get; set; }
        public DbSet<Models.RecipeIngredient> RecipeIngredientSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }



}

