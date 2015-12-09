using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloriesPerGram { get; set; }  
        public double CaloriesPerMilliliter { get; set; } 
        public double Density { get; set; }
        public bool IsDry { get; set; }
        public ICollection<AccountIngredient> AccountIngredients { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
