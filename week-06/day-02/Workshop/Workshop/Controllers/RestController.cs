using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workshop.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        public static long CallCount { get; set; } = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        [HttpGet]
        //Note that this could be replaced with
        //just a single [HttpGet("greeting")] attribute.
        public Greeting Greet(string name)
        {
            CallCount++;
            return new Greeting(name);
        }
    }
}
