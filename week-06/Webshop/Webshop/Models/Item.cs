using System;
namespace Webshop.Models
{
    public class Item
    {
        //name, description, price, quantityOfStock
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int QtyInStock { get; private set; }

        public Item(string name, string description, double price, int qty)
        {
            Name = name;
            Description = description;
            Price = price;
            QtyInStock = qty;
        }

        public double CurrencyConvert(double exchangeRate)
        {
            return Price * exchangeRate;
        }
    }
}
