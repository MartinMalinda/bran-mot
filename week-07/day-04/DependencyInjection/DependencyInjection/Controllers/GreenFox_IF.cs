using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    [Route("gfa-if")]
    public class GreenFox_IF : Controller
    {
        IStudentService StudenServiceIF;

        public GreenFox_IF(IStudentService StudentServiceIF)
        {
            this.StudenServiceIF = StudentServiceIF;
        }

        // GET: /<controller>/
        public IActionResult Index()

        {
            return View(StudenServiceIF.StudentCount());
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(StudenServiceIF.FindAll());
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet("save")]
        public IActionResult Save(string name)
        {
            StudenServiceIF.Save(name);
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
            return View(StudenServiceIF.StudentChecker(name));
        }
    }
}
