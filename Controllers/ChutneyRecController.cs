using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MYFIRSTAPP.Controllers 
{
    public class ChutneyRecController : Controller
    {
        public IActionResult AlmondChutney()
        {
            return View();
        }

    }
}