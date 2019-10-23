using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop.Controllers
{
    [Route("webshop")]
    public class Webshop : Controller
    {
        [HttpGet("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(StockList.GetExampleList());
        }

        [HttpGet("only-available")]
        // GET: /<controller>/
        public IActionResult OnlyAvailable()
        {
            return View(StockList.GetOnlyAvailable(StockList.GetExampleList()));
        }

        [HttpGet("cheapest-first")]
        // GET: /<controller>/
        public IActionResult CheapestFirst()
        {
            return View(StockList.GetCheapestFirst(StockList.GetExampleList()));
        }

        [HttpGet("contains-nike")]
        // GET: /<controller>/
        public IActionResult containsNike()
        {
            return View(StockList.GetNike(StockList.GetExampleList()));
        }

        [HttpGet("average-stock")]
        // GET: /<controller>/
        public IActionResult averageStock()
        {
            ViewData["average"] = StockList.GetAverageStock(StockList.GetExampleList());
            return View();
        }

        [HttpGet("most-expensive")]
        public IActionResult mostExpensive()
        {
            ViewData["most-expensive"] = StockList.GetMostExpensive(StockList.GetExampleList());
            return View(); 
        }
    }
}
