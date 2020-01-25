using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }

        void SaveRecipe(Recipe recipe, Cuisine cuisine);

        Recipe DeleteRecipe(int recipeId);
    }
}
