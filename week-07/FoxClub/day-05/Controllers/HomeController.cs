using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day05.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace day05.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private IFox FoxService;

        public HomeController(IFox foxService)
        {
            FoxService = foxService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(FoxService.GetCurrentFox());
            
        }

        //[HttpGet("")]
        //public IActionResult Index(string name)
        //{
        //    return View();
        //}

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            
            FoxService.AddFox(name);
            FoxService.ChangeFox(name);
            return RedirectToAction("Index", "Home", new { name = FoxService.GetCurrentFox().Name});
        }

    }
}
