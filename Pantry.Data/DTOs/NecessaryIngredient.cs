namespace Pantry.Data.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    [DataContract]
    public class NecessaryIngredient
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int RecipeId { get; set; }
        [DataMember]
        public int IngredientId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsDry { get; set; }
        [DataMember]
        public bool HasUniqueBaseAmountType { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
    }
}
