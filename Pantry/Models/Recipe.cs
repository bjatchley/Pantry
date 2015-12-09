﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}