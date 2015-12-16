namespace Pantry.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Data.DTOs;
    using Pantry.Data.Models;

    [ServiceContract]
    public interface IPantryService
    {
        [OperationContract]
        IQueryable<Recipe> GetRecipes();
        [OperationContract]
        IQueryable<Account> GetAccounts();
        [OperationContract]
        void AddIngredientToPantry(AvailableIngredient accountIngredient);
    }
}
