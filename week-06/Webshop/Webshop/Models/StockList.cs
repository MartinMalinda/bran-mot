﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Webshop.Models
{
    public class StockList
    {
        public static List<Item> Inventory { get; private set; } = new List<Item>
        {
            new Item("Running Shoes", "Nike running shoes for every day sport", 1000.00, 5),
            new Item("Printer", "Some HP printer that will print pages", 3000.00, 2),
            new Item("Coca Cola", "0.5l standard coke", 25.9, 0),
            new Item("Wokin", "Chicken with friend rice and WOKIN sauce", 119.0, 100),
            new Item("T-shirt", "Blue iwth a corgi on a bike", 300.0, 1),
        };

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

        public static List<Item>filterByPrice (string bounds, double amount)
        {
            var priceFiltered = new List<Item>();
            switch (bounds)
            {
                case "above":
                    priceFiltered = StockList.Inventory.Where(n => n.Price > amount).ToList();
                    break;
                case "below":
                    priceFiltered = StockList.Inventory.Where(n => n.Price < amount).ToList();
                    break;
                default:
                    priceFiltered = StockList.Inventory.Where(n => n.Price == amount).ToList();
                    break;
            }
            return priceFiltered;
        }
    }
}
