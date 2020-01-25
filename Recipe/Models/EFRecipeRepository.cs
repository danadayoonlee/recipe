using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public IQueryable<Cuisine> Cuisines => context.Cuisines;

        public void SaveRecipe(Recipe recipe, Cuisine cuisine)
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();

            foreach (var item in cuisineList)
            {
                if (cuisine.CuisineType.Equals(item.CuisineType))
                {
                    recipe.Cuisine = cuisineList.Find(c => c.CuisineType == item.CuisineType);
                }
            }

            if (recipe.RecipeID == 0)
            {
                recipe.PostingTime = DateTime.Now;
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe recipeEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeID == recipe.RecipeID);

                Cuisine cuisineEntry = context.Cuisines
                    .FirstOrDefault(c => c.CuisineID == cuisine.CuisineID);

                if (recipeEntry != null)
                {
                    recipeEntry.Name = recipe.Name;
                    recipeEntry.Cuisine = recipe.Cuisine;
                    recipeEntry.Introduction = recipe.Introduction;
                    recipeEntry.Ingredients = recipe.Ingredients;
                    recipeEntry.Directions = recipe.Directions;
                    recipeEntry.Time = recipe.Time;
                    recipeEntry.Difficulty = recipe.Difficulty;
                    recipeEntry.Vegetarian = recipe.Vegetarian;
                    recipeEntry.Allergy = recipe.Allergy;
                }
                if (cuisineEntry != null)
                {
                    cuisineEntry.CuisineType = cuisine.CuisineType;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int recipeId)
        {
            Recipe recipeEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeID == recipeId);

            if (recipeEntry != null)
            {
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }
    }
}
