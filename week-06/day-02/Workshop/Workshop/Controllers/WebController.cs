using System;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                ID = 1,
                Content = "from the model"
            };

            ViewData["Name"] = name;
            ViewData["Hello"] = greeting.ChooseLanguage();

            return View(greeting);
        }
    }
}
