namespace Pantry.Services.DataContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class AccountIngredient
    {
        public int AccountId { get; set; }
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public bool IsDry { get; set; }
        public bool HasUniqueBaseAmountType { get; set; }
        public decimal Amount { get; set; }
    }
}
