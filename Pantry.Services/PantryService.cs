namespace Pantry.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Services.Repositories;

    class PantryService : IPantryService
    {

        #region IPantryService Members

        public IEnumerable<DataContracts.Recipe> GetRecipes()
        {
            RecipeRepository recipeRepository = new RecipeRepository();

            return recipeRepository.GetRecipes();
        }

        public IEnumerable<DataContracts.Account> GetAccounts()
        {
            AccountRepository accountRepository = new AccountRepository();

            return accountRepository.GetAccounts();
        }

        public void AddIngredientToPantry(DataContracts.AccountIngredient accountIngredient)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
