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
            var Recs = new RecipeDatabase();
            return View(Recs);
        }
    }
}