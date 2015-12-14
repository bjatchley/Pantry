namespace Pantry.Data.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data.Models;

    public static class DbSeedHelper
    {
        public static void SeedRecipeDatabase(PantryContext context)
        {
            List<Account> AccountList = new List<Account>{
                new Account{Email = "bj@atchley.org", FirstName = "BJ", LastName = "Atchley"},
                new Account{Email = "bob@123.com", FirstName = "Bob", LastName = "Wencelas"},
                new Account{Email = "Bill@321.com", FirstName = "Bill", LastName = "Brasky"},
                new Account{Email = "Carrie@aol.com", FirstName = "Carrie", LastName = "Fisher"},
                new Account{Email = "Susan@apok.net", FirstName = "Susan", LastName = "Strong"},
                new Account{Email = "Darkthoughts@myprivateparadise.sump", FirstName = "Marceline", LastName = "Vampire"}
            };

            context.AccountSet.AddOrUpdate(p => p.Email, AccountList.ToArray());

            context.SaveChanges();

            List<Ingredient> IngredientList = new List<Ingredient>{
                new Ingredient{HasUniqueBaseAmountType=true, Name = "Egg", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Flour", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Sugar", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Water", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Heavy Cream", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Buttermilk", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Honey", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Butter", IsDry = false},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Dry Yeast", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=true, Name = "Bread Slice", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=true, Name = "Ham Slice", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Salt", IsDry = true},
                new Ingredient{HasUniqueBaseAmountType=false, Name = "Mayonnaise", IsDry = false}
            };

            context.IngredientSet.AddOrUpdate(p => p.Name, IngredientList.ToArray());

            context.SaveChanges();

            List<AccountIngredient> AccountIngredientList = new List<AccountIngredient> { 
                new AccountIngredient { AccountId=1, IngredientId=1, Amount=36},
                new AccountIngredient { AccountId=1, IngredientId=2, Amount=2400},
                new AccountIngredient { AccountId=1, IngredientId=3, Amount=1600},
                new AccountIngredient { AccountId=1, IngredientId=4, Amount=10000},
                new AccountIngredient { AccountId=1, IngredientId=5, Amount=475},
                new AccountIngredient { AccountId=1, IngredientId=6, Amount=950},
                new AccountIngredient { AccountId=1, IngredientId=7, Amount=475},
                new AccountIngredient { AccountId=1, IngredientId=8, Amount=240},
                new AccountIngredient { AccountId=1, IngredientId=9, Amount=105},
                new AccountIngredient { AccountId=1, IngredientId=10, Amount=4},
                new AccountIngredient { AccountId=1, IngredientId=11, Amount=1},
                new AccountIngredient { AccountId=2, IngredientId=1, Amount=12},
                new AccountIngredient { AccountId=3, IngredientId=2, Amount=24000}
            };

            context.AccountIngredientSet.AddOrUpdate(p => new { p.AccountId, p.IngredientId }, AccountIngredientList.ToArray());

            context.SaveChanges();

            List<Recipe> RecipeList = new List<Recipe> {
                new Recipe {AccountId=1, Name="Bread"},
                new Recipe {AccountId=1, Name="Fried Eggs"},
                new Recipe {AccountId=1, Name="Sandwich"}
            };

            context.RecipeSet.AddOrUpdate(p => p.Name, RecipeList.ToArray());

            context.SaveChanges();

            List<RecipeIngredient> RecipeIngredientList = new List<RecipeIngredient> {
                new RecipeIngredient{ RecipeId=1, IngredientId=2, Amount=710},
                new RecipeIngredient{ RecipeId=1, IngredientId=3, Amount=30},
                new RecipeIngredient{ RecipeId=1, IngredientId=1, Amount=1},
                new RecipeIngredient{ RecipeId=1, IngredientId=6, Amount=300},
                new RecipeIngredient{ RecipeId=1, IngredientId=8, Amount=60},
                new RecipeIngredient{ RecipeId=1, IngredientId=12, Amount=5},
                new RecipeIngredient{ RecipeId=1, IngredientId=9, Amount=7.5M},
                new RecipeIngredient{ RecipeId=2, IngredientId=1, Amount=3},
                new RecipeIngredient{ RecipeId=2, IngredientId=10, Amount=3},
                new RecipeIngredient{ RecipeId=2, IngredientId=8, Amount=30},
                new RecipeIngredient{ RecipeId=3, IngredientId=10, Amount=2},
                new RecipeIngredient{ RecipeId=3, IngredientId=11, Amount=2},
                new RecipeIngredient{ RecipeId=3, IngredientId=13, Amount=20}
            };

            context.RecipeIngredientSet.AddOrUpdate(p => new { p.RecipeId, p.IngredientId }, RecipeIngredientList.ToArray());

            context.SaveChanges();
        }
    }
}
