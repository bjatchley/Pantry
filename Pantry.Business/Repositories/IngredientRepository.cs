namespace Pantry.Business.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Data.DTOs;
    using Common.Base.Classes;
    using Factories;


    public class IngredientRepository : DataRepositoryBase<Ingredient, PantryContext>, IIngredientRepository
    {
        IRepositoryFactory _repositoryFactory;

        public IngredientRepository(IRepositoryFactory repositoryFactory) 
        {
            _repositoryFactory = repositoryFactory;
        }

        public AvailableIngredient AddAvailableIngredient(AvailableIngredient availableIngredient)
        {
            AvailableIngredient result = new AvailableIngredient();

            IAccountRepository accountRepository = _repositoryFactory.GetRepository<IAccountRepository>();
            Account ingredientOwner = accountRepository.Get(availableIngredient.AccountId);

            //check if has ID for now just return will handle amount adding later
            if (availableIngredient.IngredientId > 0){
                throw new NotImplementedException("Ingredient Already Exists Add code to handle this. " 
                    + "IngredientRepository.AddAvailableIngredient");
            }
            
            Ingredient existingIngredient;
            AccountIngredient accountIngredientToInsert;

            using (PantryContext context = new PantryContext())
            {
                existingIngredient = GetIngredientByName(availableIngredient.Name);

                if (existingIngredient == null)
                {
                    existingIngredient = new Ingredient();
 
                    existingIngredient.IsDry = availableIngredient.IsDry;
                    existingIngredient.HasUniqueBaseAmountType = availableIngredient.HasUniqueBaseAmountType;
                    existingIngredient.Name = availableIngredient.Name;

                    context.IngredientSet.Add(existingIngredient);
                    context.SaveChanges();
                }

                accountIngredientToInsert = new AccountIngredient();

                accountIngredientToInsert.Amount = availableIngredient.Amount;
                accountIngredientToInsert.IngredientId = existingIngredient.Id;

                ingredientOwner.AccountIngredients.Add(accountIngredientToInsert);

                context.SaveChanges();
            }

            result.AccountId = ingredientOwner.Id;
            result.IngredientId = existingIngredient.Id;
            result.Id = accountIngredientToInsert.Id;
            result.Amount = availableIngredient.Amount;
            result.HasUniqueBaseAmountType = availableIngredient.HasUniqueBaseAmountType;
            result.IsDry = availableIngredient.IsDry;
            result.Name = availableIngredient.Name;

            return result;
        }

        public Ingredient GetIngredientByName(string name)
        {
            using (PantryContext context = new PantryContext())
            {
                return context.IngredientSet.Where(p => p.Name == name).FirstOrDefault();
            }
        }

        #region Statements used by basic CRUD
        protected override Ingredient AddEntity(PantryContext entityContext, Ingredient entity)
        {
            return entityContext.IngredientSet.Add(entity);
        }

        protected override Ingredient UpdateEntity(PantryContext entityContext, Ingredient entity)
        {
            return entityContext.IngredientSet.Where(p => p.Id == entity.Id).FirstOrDefault();
        }

        protected override IQueryable<Ingredient> GetEntities(PantryContext entityContext)
        {
            return entityContext.IngredientSet;
        }

        protected override Ingredient GetEntity(PantryContext entityContext, int id)
        {
            return entityContext.IngredientSet.Where(p => p.Id == id).FirstOrDefault();
        }
        #endregion
    }
}
