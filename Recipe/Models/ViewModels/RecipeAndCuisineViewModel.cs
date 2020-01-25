using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models.ViewModels
{
    public class RecipeAndCuisineViewModel
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public IEnumerable<Cuisine> Cuisines { get; set; }

        public Recipe Recipe { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
