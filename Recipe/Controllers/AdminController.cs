using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem.Models;
using RecipeSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Controllers
{
    [Authorize(Roles = "Admin, Manager")] // Only authorized user can access
    public class AdminController : Controller
    {
        private IRecipeRepository rRepository;
        private ICuisineRepository cRepository;
        private ApplicationDbContext context;

        public AdminController(IRecipeRepository rRepo, ICuisineRepository cRepo, ApplicationDbContext ctx)
        {
            rRepository = rRepo;
            cRepository = cRepo;
            context = ctx;
        }

        public ViewResult Index()
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();

            RecipeAndCuisineViewModel RACV = new RecipeAndCuisineViewModel();
            RACV.Recipes = rRepository.Recipes;
            RACV.Cuisines = cRepository.Cuisines;
            return View(RACV);
        }

        public ViewResult Edit(int recipeId)
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();
            ViewBag.listofitems = cuisineList;

            return View(rRepository.Recipes.FirstOrDefault(r => r.RecipeID == recipeId));
        }

        [HttpPost]
        public IActionResult Edit(Recipe recipe, Cuisine cuisine)
        {
            if (ModelState.IsValid)
            {
                rRepository.SaveRecipe(recipe, cuisine);
                TempData["message"] = $"{recipe.Name} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult Create()
        {
            List<Cuisine> cuisineList = new List<Cuisine>();
            cuisineList = context.Cuisines.ToList();
            ViewBag.listofitems = cuisineList;

            return View("Edit", new Recipe());
        }

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = rRepository.DeleteRecipe(recipeId);

            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.Name} was deleted!";
            }

            return RedirectToAction(nameof(Index));
        }

        public ViewResult CuisineIndex() => View(cRepository.Cuisines);

        public ViewResult CreateCuisine() => View("EditCuisine", new Cuisine());

        public ViewResult EditCuisine(int cuisineId) => View(cRepository.Cuisines.FirstOrDefault(c => c.CuisineID == cuisineId));

        [HttpPost]
        public IActionResult EditCuisine(Cuisine cuisine)
        {
            if (ModelState.IsValid)
            {
                cRepository.SaveCuisine(cuisine);
                TempData["message"] = $"{cuisine.CuisineType} Cuisine has been saved!";
                return RedirectToAction(nameof(CuisineIndex));
            }
            else
            {
                return View(cuisine);
            }
        }

        public IActionResult DeleteCuisine(int cuisineId)
        {
            Cuisine deletedCuisine = cRepository.DeleteCuisine(cuisineId);

            if (deletedCuisine != null)
            {
                TempData["message"] = $"{deletedCuisine.CuisineType} was deleted!";
            }
            return RedirectToAction(nameof(CuisineIndex));
        }
    }
}
