namespace Pantry.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Ingredient
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool IsDry { get; set; }
        [DataMember]
        public bool HasUniqueBaseAmountType { get; set; }
        [DataMember]
        public virtual ICollection<AccountIngredient> AccountIngredients { get; set; }
        [DataMember]
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
