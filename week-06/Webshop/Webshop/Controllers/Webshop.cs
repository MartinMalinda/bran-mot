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
            return View(StockList.Inventory);
        }

        [HttpGet("only-available")]
        // GET: /<controller>/
        public IActionResult OnlyAvailable()
        {
            return View(StockList.GetOnlyAvailable(StockList.Inventory));
        }

        [HttpGet("cheapest-first")]
        // GET: /<controller>/
        public IActionResult CheapestFirst()
        {
            return View(StockList.GetCheapestFirst(StockList.Inventory));
        }

        [HttpGet("contains-nike")]
        // GET: /<controller>/
        public IActionResult containsNike()
        {
            return View(StockList.GetNike(StockList.Inventory));
        }

        [HttpGet("average-stock")]
        // GET: /<controller>/
        public IActionResult averageStock()
        {
            ViewData["average"] = StockList.GetAverageStock(StockList.Inventory);
            return View();
        }

        [HttpGet("most-expensive")]
        public IActionResult mostExpensive()
        {
            ViewData["most-expensive"] = StockList.GetMostExpensive(StockList.Inventory);
            return View(); 
        }

        [HttpPost("search")]
        public IActionResult Search(string search)
        {
            return View(StockList.GetSearch(StockList.Inventory, search));
        }

        [HttpGet("more-filters")]
        public IActionResult moreFilters()
        {
            return View(StockList.Inventory);
        }

        [HttpGet("price-in-eur")]
        public IActionResult priceInEuros()
        {
            return View(StockList.Inventory);
        }

        [HttpGet("original-currency")]
        public IActionResult originalCurrency()
        {
            return View(StockList.Inventory);
        }

        [HttpPost("filter-by-price")]
        public IActionResult filterByPrice(string byPrice, double number)
        {
            return View(StockList.filterByPrice(byPrice, number));
        }
    }
}
