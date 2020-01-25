using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeSystem.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        [Required(ErrorMessage = "Please enter your recipe's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your recipe's introduction")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter your recipe's ingredients")]
        public string Introduction { get; set; }

        [Required(ErrorMessage = "Please enter your recipe's directions")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Please enter your recipe's cooking time in minutes")]
        public int Time { get; set; }

        [Required(ErrorMessage = "Please specify recipe's level of difficulty")]
        public string Difficulty { get; set; }

        public bool Vegetarian { get; set; }

        public bool Allergy { get; set; }

        public DateTime PostingTime { get; set; }

        public Cuisine Cuisine { get; set; }
    }
}
