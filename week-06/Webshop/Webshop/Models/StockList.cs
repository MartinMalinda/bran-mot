using System;
using System.Collections.Generic;
using System.Linq;

namespace Webshop.Models
{
    public class StockList
    {
        public static List<Item> Inventory { get; private set; }

        public StockList()
        {
            Inventory = new List<Item>();
        }

        public static List<Item> GetExampleList()
        {
            List<Item> exampleList = new List<Item>();
            exampleList.Add(new Item("Running Shoes", "Nike running shoes for every day sport", 1000.00, 5));
            exampleList.Add(new Item("Printer", "Some HP printer that will print pages", 3000.00, 2));
            exampleList.Add(new Item("Coca Cola", "0.5l standard coke", 25.0, 0));
            exampleList.Add(new Item("Wokin", "Chicken with friend rice and WOKIN sauce", 119.0, 100));
            exampleList.Add(new Item("T-shirt", "Blue iwth a corgi on a bike", 300.0, 1));
            return exampleList;
        }

        public void AddItem(string name, string description, double price, int qty)
        {
            Inventory.Add
                (
                    new Item(name, description, price, qty)
                );
        }

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
    }
}
