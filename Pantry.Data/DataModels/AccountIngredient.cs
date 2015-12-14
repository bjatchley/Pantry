using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class AccountIngredient
    {
        [Key, Column(Order = 0)]
        public int AccountId { get; set; }
        [Key, Column(Order = 1)]
        public int IngredientId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public decimal Amount { get; set; }
    }
}
