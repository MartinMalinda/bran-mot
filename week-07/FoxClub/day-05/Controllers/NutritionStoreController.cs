using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day05.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace day05.Controllers
{
    [Route("nutritionStore/")]
    public class NutritionStoreController : Controller
    {
        private IFox FoxService;
        private IFood FoodService;

        public NutritionStoreController(IFox foxService, IFood foodService)
        {
            this.FoxService = foxService;
            this.FoodService = foodService;
        }

        [HttpGet("")]
        public IActionResult NutritionStore()
        {
            return View(FoxService.GetCurrentFox());
            
        }
    }
}
