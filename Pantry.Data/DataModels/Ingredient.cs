namespace Pantry.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDry { get; set; }
        public bool HasUniqueBaseAmountType { get; set; }
        public virtual ICollection<AccountIngredient> AccountIngredients { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
