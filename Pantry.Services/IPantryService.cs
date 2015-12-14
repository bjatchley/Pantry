namespace Pantry.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Services.DataContracts;

    [ServiceContract]
    public interface IPantryService
    {
        [OperationContract]
        IEnumerable<Recipe> GetRecipes();
        [OperationContract]
        IEnumerable<Account> GetAccounts();
        [OperationContract]
        void AddIngredientToPantry(AccountIngredient accountIngredient);
    }
}
