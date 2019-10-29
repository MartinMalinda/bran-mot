using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    
    public class HomeController : Controller
    {

        public static List<BankAccount> AllAccounts { get; set; } = new List<BankAccount>
        {
            new BankAccount("Timon", 50000.00, "Meerkat", "on"),
            new BankAccount("Poomba", 0.01, "Warthog"),
            new BankAccount("Ariel", 5.03, "Mermaid"),
            new BankAccount("Mulan", 25.43, "Human", "on", "on")
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("show")]
        public IActionResult ShowSimba()
        {
            var simba = new BankAccount("Simba", 2000, "lion");
            ViewBag.Item = simba;
            return View();
        }

        [HttpGet("htmlception")]
        public IActionResult htmlCeption()
        {
            ViewData["string"] = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View();
        }
        [HttpGet("all-accounts")]
        public IActionResult allAccounts()
        {
            return View(AllAccounts);
        }
        [HttpPost("all-accounts")]
        public IActionResult allAccounts(string name, double balance, string species, string king, string goodGuy)
        {
            AllAccounts.Add(new BankAccount(name, balance, species, king, goodGuy));
            return View(AllAccounts);
        }

        [HttpPost("increase-accounts")]
        public IActionResult increaseAccounts(bool increase)
        {
            foreach (var account in AllAccounts)
            {
                if (account.IsKing)
                {
                    account.Balance += 1000;
                }
                else
                {
                    account.Balance += 10;
                }
            }
            return RedirectToAction("allAccounts");
        }

    }
}
