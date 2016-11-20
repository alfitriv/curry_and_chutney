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
    }
}