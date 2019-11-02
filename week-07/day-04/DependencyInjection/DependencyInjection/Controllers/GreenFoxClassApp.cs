using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    [Route("gfa")]
    public class GreenFoxClassApp : Controller
    {
        private StudentService StudentService;

        public GreenFoxClassApp(StudentService studentService)
        {
            this.StudentService = studentService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(StudentService.StudentCount());
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(StudentService.FindAll());
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet("save")]
        public IActionResult Save(string name)
        {
            StudentService.Save(name);
            ViewData["added-student"] = name;
            return View();
        }

        [HttpGet("check")]
        public IActionResult Check()
        {
            return View();
        }

        [HttpPost("check")]
        public IActionResult CheckResults(string name)
        {
            return View(StudentService.StudentChecker(name));
        }
    }
}
