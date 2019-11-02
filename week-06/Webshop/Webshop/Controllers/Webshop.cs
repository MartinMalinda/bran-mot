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
        public static List<Item> Inventory { get; private set; } = new List<Item>
        {
            new Item("Running Shoes", "Nike running shoes for every day sport", 1000.00, 5),
            new Item("Printer", "Some HP printer that will print pages", 3000.00, 2),
            new Item("Coca Cola", "0.5l standard coke", 25.9, 0),
            new Item("Wokin", "Chicken with friend rice and WOKIN sauce", 119.0, 100),
            new Item("T-shirt", "Blue iwth a corgi on a bike", 300.0, 1),
        };

        [HttpGet("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Inventory);
        }

        [HttpGet("only-available")]
        // GET: /<controller>/
        public IActionResult OnlyAvailable()
        {
            return View(StockList.GetOnlyAvailable(Inventory));
        }

        [HttpGet("cheapest-first")]
        // GET: /<controller>/
        public IActionResult CheapestFirst()
        {
            return View(StockList.GetCheapestFirst(Inventory));
        }

        [HttpGet("contains-nike")]
        // GET: /<controller>/
        public IActionResult containsNike()
        {
            return View(StockList.GetNike(Inventory));
        }

        [HttpGet("average-stock")]
        // GET: /<controller>/
        public IActionResult averageStock()
        {
            ViewData["average"] = StockList.GetAverageStock(Inventory);
            return View();
        }

        [HttpGet("most-expensive")]
        public IActionResult mostExpensive()
        {
            ViewData["most-expensive"] = StockList.GetMostExpensive(Inventory);
            return View(); 
        }

        [HttpPost("search")]
        public IActionResult Search(string search)
        {
            return View(StockList.GetSearch(Inventory, search));
        }

        [HttpGet("more-filters")]
        public IActionResult moreFilters()
        {
            return View(Inventory);
        }

        [HttpGet("price-in-eur")]
        public IActionResult priceInEuros()
        {
            return View(Inventory);
        }

        [HttpGet("original-currency")]
        public IActionResult originalCurrency()
        {
            return View(Inventory);
        }

        [HttpPost("filter-by-price")]
        public IActionResult filterByPrice(string byPrice, double number)
        {
            return View(StockList.filterByPrice(Inventory, byPrice, number));
        }
    }
}
