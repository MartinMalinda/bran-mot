using System;
using System.Text;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        public static Dictionary<string, int> CreateMap (string[] productsToAdd, int[] pricesToAdd)
        {
            Dictionary<string, int> productDatabase = new Dictionary<string, int>();

            for (int i = 0; i < productsToAdd.Length; i++)
            {
                productDatabase.Add(productsToAdd[i], pricesToAdd[i]);
            }
            return productDatabase;
        }
        public static int PriceLookup(string itemToSearch, Dictionary<string, int> productsToSearch)
        {
            int price = 0;
            if (productsToSearch.TryGetValue(itemToSearch, out price))
            {
                return price;
            }
            else
            {
                return -1;
            }

        }
        public static double GetAveragePrice(Dictionary<string, int> pricesToAverage)
        {
            double totalPrice = 0;
            foreach (KeyValuePair<string, int> price in pricesToAverage)
            {
                totalPrice = totalPrice + price.Value;
            }
            return totalPrice / pricesToAverage.Count;
        }
        public static int ProductsBelowPrice(Dictionary<string, int> prices, int maxPrice)
        {
            int qtyBelow = 0;
            foreach (KeyValuePair<string, int> price in prices)
            {
                if (price.Value < maxPrice)
                {
                    qtyBelow++;
                }
            }
            return qtyBelow;
        }
        public static string ProductsExactlyAtPrice (Dictionary<string, int> pricesToSearch, int exactPrice)
        {
            if(pricesToSearch.ContainsValue(exactPrice)){
                return "You can buy something with " + exactPrice;
            }
            else
            {
                return "You cannot buy something with " + exactPrice;
            }
        }
        static void Main(string[] args)
        {
            //We are going to represent our products in a map where the keys are strings representing the product's name and the values are numbers representing the product's price.

            //Create a map with the following key - value pairs.

            //  Product name(key)  Price(value)
            //Eggs    200
            //Milk    200
            //Fish    400
            //Apples  150
            //Bread   50
            //Chicken 550
            //Create an application which solves the following problems.
            string[] products = { "Eggs", "Milk", "Fish", "Apples", "Bread", "Chicken" };
            int[] prices = { 200, 200, 400, 150, 50, 550 };
            var db = CreateMap(products, prices);

            //How much is the fish ?
            Console.WriteLine(PriceLookup("Fish", db));

            //What is the most expensive product?
            //What is the average price?
            Console.WriteLine("The average price of all items is {0}", GetAveragePrice(db));

            //How many products' price is below 300?
            Console.WriteLine("The number of products below 300 is {0}", ProductsBelowPrice(db, 300));

            //Is there anything we can buy for exactly 125 ?
            Console.WriteLine(ProductsExactlyAtPrice(db, 125));

            //What is the cheapest product ?



        }

    }
}
