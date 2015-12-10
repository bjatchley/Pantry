using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class PantryContext : DbContext
    {
        public DbSet<Account> AccountSet { get; set; }
        public DbSet<Ingredient> IngredientSet { get; set; }
        public DbSet<Recipe> RecipeSet { get; set; }
        public DbSet<AccountIngredient> AccountIngredientSet { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredientSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }



}

