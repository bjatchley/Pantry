using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.Data.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<AccountIngredient> AccountIngredients { get; set; }
    }
}
