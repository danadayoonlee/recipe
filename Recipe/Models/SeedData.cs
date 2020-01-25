using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RecipeSystem.Models
{
    public static class SeedData
    {
        private static Cuisine American;
        private static Cuisine Italian;
        private static Cuisine French;
        private static Cuisine Chinese;
        private static Cuisine Korean;

        public static void EnsurePopulated(IApplicationBuilder app) // This method will ensure that the DB is populated with data
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            context.Cuisines.AddRange(
                American = new Cuisine
                {
                    CuisineType = "American"
                },
                Italian = new Cuisine
                {
                    CuisineType = "Italian"
                },
                French = new Cuisine
                {
                    CuisineType = "French"
                },
                Chinese = new Cuisine
                {
                    CuisineType = "Chinese"
                },
                Korean = new Cuisine
                {
                    CuisineType = "Korean"
                }
            );

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        Name = "Sticky Chicken Wings",
                        Introduction = "Crispy, sticky, sweet, savory with the most perfect caramelized glaze. Basically best party food ever. SO FINGER-LICKING GOOD.",
                        Ingredients = "2 1/2 pounds chicken wings or drumettes, Kosher salt and freshly ground black pepper, to taste, 1 1/2 tablespoons baking powder, 1/3 cup oyster sauce, 1/3 cup ketchup, 2 tablespoons orange marmalade, 1 tablespoon Dijon mustard, 1 tablespoon honey, 1 tablespoon chili garlic sauce, or more, to taste, 3 green onions, thinly sliced, 1 teaspoon toasted sesame seeds",
                        Directions = "1. Preheat oven to 425 degrees F. 2. In a large bowl, combine wings, 1 1/2 teaspoons salt, 1 teaspoon pepper and baking powder. 3. Place wings onto the prepared baking sheet and bake for 40-45 minutes. 4. In a small saucepan, combine oyster sauce, ketchup, marmalade, Dijon, honey and chili garlic sauce. 5. Bring to a boil; reduce heat and simmer. 6. Preheat oven to broil. 7. In a large bowl, combine wings and half the oyster sauce mixture. 8. Place wings onto the prepared baking sheet and broil.",
                        Time = 80,
                        Difficulty = "Soso",
                        Vegetarian = false,
                        Allergy = false,
                        Cuisine = Korean
                    },
                    new Recipe
                    {
                        Name = "Summer Cheese Board",
                        Introduction = "Brie, gorgonzola, gouda, cheddar, fresh summer berries and cherries! The ultimate killer cheese board to impress all your guests!",
                        Ingredients = "8 ounces brie, 8 ounces gorgonzola cheese, 6 ounces aged gouda, 6 ounces white cheddar cheese, thinly sliced, 1 (6-ounce) package rosemary artisan crackers, 1 (5.3-ounce) package Lesley Stowe Raincoast Crisps, Fig and Olive, 1 cup pita bite crackers, 1 cup strawberries, 1 cup cherries, 1/2 cup raspberries, 1/2 cup blueberries, 1/2 cup marcona almonds, 1 nectarine, sliced",
                        Directions = "1. Arrange cheeses, artisan crackers, Raincoast Crisps, pita bite crackers, strawberries, cherries, raspberries, blueberries, almonds and nectarine on platter or wooden cheese board.",
                        Time = 10,
                        Difficulty = "Easy",
                        Vegetarian = false,
                        Allergy = false,
                        Cuisine = American
                    },
                    new Recipe
                    {
                        Name = "Garlic Butter Shrimp Scampi",
                        Introduction = "Made in just 20 min from start to finish! The garlic butter sauce is TO DIE FOR – so buttery, so garlicky/lemony + so perfect!",
                        Ingredients = "1/2 cup unsalted butter, cubed, 4 cloves garlic, minced, 1 medium shallot, minced, 1/4 teaspoon crushed red pepper flakes, 1 1/2 pounds medium shrimp, peeled and deveined, Kosher salt and freshly ground black pepper, to taste, 3 tablespoons chopped fresh parsley leaves, 1 tablespoon freshly squeezed lemon juice, 2 teaspoons lemon zest",
                        Directions = "1. Melt butter in a large skillet over medium heat. Add garlic, shallot and red pepper flakes, and cook. 2. Add shrimp; season with salt and pepper, to taste. Cook, stirring occasionally. 3. Stir in parsley, lemon juice and lemon zest.",
                        Time = 10,
                        Difficulty = "Easy",
                        Vegetarian = false,
                        Allergy = false,
                        Cuisine = American
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
