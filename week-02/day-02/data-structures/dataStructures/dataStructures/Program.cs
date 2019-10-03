using System;
using System.Text;
using System.Collections.Generic;

namespace dataStructures
{
    class Program
    {
        public static double TotalCost(string name, Dictionary<string, Dictionary<string, double>> listToCheck)
        {
            double value = 0;
            if (listToCheck.ContainsKey(name))
            {
                foreach (var listItem in listToCheck[name])
                {
                    value = value + listItem.Value;
                }
            }
            else
            {
                value = - 1;
            }
            return value;

        }
        public static string BoughtTheMost(string item, Dictionary<string, Dictionary<string, double>> listToCheck)
        {
            double quantity = 0;
            string boughtTheMost = "";
            foreach (var person in listToCheck)
            {
                if (person.Value[item] > quantity)
                {
                    quantity = person.Value[item];
                    boughtTheMost = person.Key;
                }
            }
            return boughtTheMost + " bought the most " + item;
        }
        private static string Variety(Dictionary<string, Dictionary<string, double>> listToCheck)
        {
            double quantity = 0;
            string mostVariety = "";

            foreach (var person in listToCheck)
            {
                if(person.Value.Count > quantity)
                {
                    quantity = person.Value.Count;
                    mostVariety = person.Key;
                }
            }
            return mostVariety + " bought the highest variety of products.";
        }
        private static string Quantity(Dictionary<string, Dictionary<string, double>> listToCheck)
        {
            double quantity = 0;
            double personalQuantity = 0;
            string highestQuantity = "";

            foreach (var person in listToCheck)
            {
                //add up all quantities of each product
                foreach (var item in person.Value)
                {
                    personalQuantity = personalQuantity + item.Value;
                }
                //check to see if the person quantity is larger than the previous value
                if (personalQuantity > quantity)
                {
                    quantity = personalQuantity;
                    highestQuantity = person.Key;
                }
                personalQuantity = 0;//reset the personalQuantity
            }
            return highestQuantity + " bought the highest quantity of items";
        }
        static void Main(string[] args)
        {
            //Represent the following products with their prices
            /*
                Product Amount
                Milk    1.07
                Rice    1.59
                Eggs    3.14
                Cheese  12.60
                Chicken Breasts 9.40
                Apples  2.31
                Tomato  2.58
                Potato  1.75
                Onion   1.10
                Represent Bob's shopping list

                Product Amount
                Milk    3
                Rice    2
                Eggs    2
                Cheese  1
                Chicken Breasts 4
                Apples  1
                Tomato  2
                Potato  1
                Represent Alice's shopping list

                Product Amount
                Rice    1
                Eggs    5
                Chicken Breasts 2
                Apples  1
                Tomato  10
            */
            //Create an application which solves the following problems.

            string[] products = { "Milk", "Rice", "Eggs", "Cheese", "Chicken Breasts", "Apples", "Tomato", "Potato", "Onion" };
            string[] names = { "Trevor", "Bob", "Alice" };
            double[,] values = {
                { 1.07, 1.59, 3.14, 12.60, 9.40, 2.31, 2.58, 1.75, 1.10 },//0 trevor
                { 3, 2, 2, 1, 4, 1, 2, 1, 0 },//1 bob
                { 0, 1, 5, 0, 2, 1, 10, 0, 0, }//2 alice
            }; 


            Dictionary<string, Dictionary<string, double>> shoppingLists = new Dictionary<string, Dictionary<string, double>>();

            for (int name = 0; name < names.Length; name++)
            {
                shoppingLists.Add(names[name], new Dictionary<string, double>());

                for (int foods = 0; foods < products.Length; foods++)
                {
                    shoppingLists[names[name]].Add(products[foods], values[name,foods]);
                }
            }
            
            //How much does Bob pay?
            Console.WriteLine(TotalCost("Bob", shoppingLists));

            //How much does Alice pay?
            Console.WriteLine(TotalCost("Alice", shoppingLists));

            //Who buys more Rice?
            Console.WriteLine(BoughtTheMost("Rice", shoppingLists));

            //Who buys more Potato?
            Console.WriteLine(BoughtTheMost("Potato", shoppingLists));

            //Who buys more different products?
            Console.WriteLine(Variety(shoppingLists));

            //Who buys more products ? (piece)
            Console.WriteLine(Quantity(shoppingLists));
        }

        
    }
}
