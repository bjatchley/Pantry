namespace Pantry.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.DTOs;
    using Data.Models;
    using Business.Repositories;
    using Business.Loaders;
    using Business.Factories;
    using System.ServiceModel;

    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class PantryService : IPantryService
    {

        IRepositoryFactory _repositoryFactory;

        public PantryService()
        {
            _repositoryFactory = new RepositoryFactory();
        }

        public PantryService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            IRecipeRepository recipeRepository = _repositoryFactory.GetRepository<IRecipeRepository>();
            
            return recipeRepository.Get();
        }

        public IEnumerable<Account> GetAccounts()
        {
            IAccountRepository accountRepository = _repositoryFactory.GetRepository<IAccountRepository>();
            var tempList = accountRepository.Get().ToList();
            return tempList.ToList();
        }

        [OperationBehavior(TransactionScopeRequired=true)]
        public void AddIngredientToPantry(AvailableIngredient availableIngredient)
        {
            IIngredientRepository ingredientRepository = _repositoryFactory.GetRepository<IIngredientRepository>();
            ingredientRepository.AddAvailableIngredient(availableIngredient);
        }

    }
}
