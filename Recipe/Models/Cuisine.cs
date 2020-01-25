using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models
{
    public class Cuisine
    {
        [Key]
        public int CuisineID { get; set; }

        [Required(ErrorMessage = "Please enter proper type of cuisine")]
        public string CuisineType { get; set; }
    }
}
