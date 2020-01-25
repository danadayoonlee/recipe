using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem.Models;
using RecipeSystem.Models.ViewModels;

namespace RecipeSystem.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository rRepository;
        private ICuisineRepository cRepository;
        private ApplicationDbContext context;
        private RecipeAndCuisineViewModel RACV = new RecipeAndCuisineViewModel();

        public HomeController(IRecipeRepository rRepo, ICuisineRepository cRepo, ApplicationDbContext ctx)
        {
            rRepository = rRepo;
            cRepository = cRepo;
            context = ctx;
        }

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning." : "Good Afternoon.";
            return View();
        }

        [HttpGet]
        public ViewResult AddRecipe()
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();
            ViewBag.listofitems = cuisineList;

            return View();
        }

        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe, Cuisine cuisine)
        {
            if (ModelState.IsValid)
            {
                rRepository.SaveRecipe(recipe, cuisine);
                return View("Thanks", recipe);
            }
            else
            {
                return View();
            }
        }

        public ViewResult RecipeList()
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();

            RACV.Recipes = rRepository.Recipes;
            RACV.Cuisines = cRepository.Cuisines;
            return View(RACV);
        }

        public ViewResult ViewRecipe(int recipeId)
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();
            ViewBag.listofitems = cuisineList;

            return View(rRepository.Recipes.FirstOrDefault(r => r.RecipeID == recipeId));
        }

        public ViewResult ReviewRecipe()
        {
            return View();
        }

        public ViewResult CreateCuisine() => View("EditCuisine", new Cuisine());

        public ViewResult EditCuisine(int cuisineId) => View(cRepository.Cuisines.FirstOrDefault(c => c.CuisineID == cuisineId));

        [HttpPost]
        public IActionResult EditCuisine(Cuisine cuisine)
        {
            if (ModelState.IsValid)
            {
                cRepository.SaveCuisine(cuisine);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cuisine);
            }
        }
    }
}
