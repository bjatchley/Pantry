namespace Pantry.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Data.DTOs;
    using Pantry.Data.Models;
    using Pantry.Services.Repositories;

    class PantryService : IPantryService
    {
        
        RecipeRepository _recipeRepository;
        AccountRepository _accountRepository;

        public IQueryable<Recipe> GetRecipes()
        {
            _recipeRepository = new RecipeRepository();

            return _recipeRepository.Get();
        }

        public IQueryable<Account> GetAccounts()
        {
            _accountRepository = new AccountRepository();

            return _accountRepository.Get();
        }

        public void AddIngredientToPantry(AvailableIngredient accountIngredient)
        {
            
        }


    }
}
