namespace Pantry.Services.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Services;
    using Data;
    using Bases;
    using Pantry.Data.Models;

    public class RecipeRepository : DataRepositoryBase<Recipe, PantryContext>, IRecipeRepository 
    {

        protected override Recipe AddEntity(PantryContext entityContext, Recipe entity)
        {
            return entityContext.RecipeSet.Add(entity);
        }

        protected override Recipe UpdateEntity(PantryContext entityContext, Recipe entity)
        {
            return entityContext.RecipeSet.Where(p => p.Id == entity.Id).FirstOrDefault();
        }

        protected override IQueryable<Recipe> GetEntities(PantryContext entityContext)
        {
            return entityContext.RecipeSet;
        }

        protected override Recipe GetEntity(PantryContext entityContext, int id)
        {
            return entityContext.RecipeSet.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
