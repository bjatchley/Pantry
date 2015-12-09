using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class RecipeIngredient
    {
        [Key, Column(Order = 0)]
        public int RecipeId { get; set; }
        [Key, Column(Order = 1)]
        public int IngredientId { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }

        //base is in milliliters
        public int Amount { get; set; }
    }
}
