namespace Pantry.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Recipe
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int AccountId { get; set; }
        [DataMember]
        public virtual Account Account { get; set; }
        [DataMember]
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
