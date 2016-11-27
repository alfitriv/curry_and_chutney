using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MYFIRSTAPP.Models;

namespace MYFIRSTAPP.Controllers 
{
    public class RecipeController : Controller
    {
        //Group the recipes by category
        public IActionResult Index()
        {
            List<Recipe> recs = new RecipeDatabase();
            List<Recipe> distinct = 
                recs
                .GroupBy(recipe => recipe.Category)
                .Select(g => g.First())
                .ToList();
            return View(distinct);
        }

        //Show the user recipes based on what category the user clicks
        public IActionResult CategorizedRecipes(string category)
        {
            List<Recipe> recs = new RecipeDatabase();
            List<Recipe> categorized_list = recs.FindAll(delegate(Recipe rec) { return rec.Category == category; });
            return View(categorized_list);
        }
        
        //Show the user detailed recipes based on what recipes the user clicks
        public IActionResult DetailedRecipes(string name)
        {
            List<Recipe> recs = new RecipeDatabase();
            List<Recipe> detailed_list = recs.FindAll(delegate(Recipe rec) { return rec.Name == name; });
            return View(detailed_list);
        }

    }
}