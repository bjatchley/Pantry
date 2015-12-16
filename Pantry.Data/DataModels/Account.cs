namespace Pantry.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Account
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public virtual ICollection<Recipe> Recipes { get; set; }
        [DataMember]
        public virtual ICollection<AccountIngredient> AccountIngredients { get; set; }
    }
}
