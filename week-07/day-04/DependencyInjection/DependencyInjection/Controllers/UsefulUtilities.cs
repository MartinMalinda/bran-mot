using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    [Route("useful")]
    public class UsefulUtilities : Controller
    {
        private UtilityService utilities;

        public UsefulUtilities(UtilityService utilities)
        {
            this.utilities = utilities;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("colored")]
        public  IActionResult Colored()
        {
            ViewData["background-color"] = utilities.RandomColor();
            return View();
        }
        [HttpGet("email")]
        public IActionResult Email(string email)
        {

            return View();
        }
    }
}
