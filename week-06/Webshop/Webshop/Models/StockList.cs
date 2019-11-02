using System;
using System.Collections.Generic;
using System.Linq;
using Webshop.Controllers;

namespace Webshop.Models
{
    public class StockList
    {        

        public static List<Item> GetOnlyAvailable(List<Item> items)
        {
            return items.Where(n => n.QtyInStock > 0).ToList();
        }

        public static List<Item> GetCheapestFirst(List<Item> items)
        {
            return items.OrderBy(n => n.Price).ToList();
        }

        public static List<Item> GetNike(List<Item> items)
        {
            return items.Where(n => n.Description.ToLower().Contains("nike") || n.Name.ToLower().Contains("nike")).ToList();
        }

        public static double GetAverageStock(List<Item> items)
        {
            return items.Average(n => n.QtyInStock);
        }

        public static string GetMostExpensive(List<Item> items)
        {
             return items.OrderByDescending(n => n.Price).First().Name;
        }

        public static List<Item> GetSearch(List<Item> items, string query)
        {
            return items.Where(n => n.Description.ToLower().Contains(query.ToLower()) || n.Name.ToLower().Contains(query.ToLower())).ToList();
        }

        public static List<Item>filterByPrice (List<Item> items, string bounds, double amount)
        {
            var priceFiltered = new List<Item>();
            switch (bounds)
            {
                case "above":
                    priceFiltered = items.Where(n => n.Price > amount).ToList();
                    break;
                case "below":
                    priceFiltered = items.Where(n => n.Price < amount).ToList();
                    break;
                default:
                    priceFiltered = items.Where(n => n.Price == amount).ToList();
                    break;
            }
            return priceFiltered;
        }
    }
}
