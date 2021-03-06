﻿namespace Pantry.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountIngredient
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public decimal Amount { get; set; }
    }
}
