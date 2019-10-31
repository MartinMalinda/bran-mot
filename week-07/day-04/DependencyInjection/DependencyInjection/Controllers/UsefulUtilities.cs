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
            if (utilities.CheckEmail(email))
            {
                ViewData["valid-email"] = email + " is a valid email address";
            }
            else
            {
                ViewData["invalid-email"] = email + " is not a valid email address";
            }
            return View();
        }

        [HttpGet("caesar-encode")]
        public IActionResult CaesarEncode(string text, int number)
        {
            ViewData["encoded"] = utilities.Caesar(text, number);
            return View();
        }

        [HttpGet("caesar-decode")]
        public IActionResult CaesarDecode(string text, int number)
        {
            int negative = -Math.Abs(number);
            ViewData["decoded"] = utilities.Caesar(text, negative);
            return View();
        }
    }
}
