using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; set; }
        public string AnimalType { get; private set; }
        public bool IsKing { get; private set; } = false;
        public bool IsGoodGuy { get; private set; } = true;

        public BankAccount(string name, double balance, string animalType )
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

        public BankAccount(string name, double balance, string animalType, bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            if (isKing)
            {
                IsKing = true;
            }
        }

        public BankAccount(string name, double balance, string animalType, bool isKing, bool isEvil)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            if (isKing)
            {
                IsKing = true;
            }
            if (isEvil)
            {
                IsGoodGuy = false;
            }
        }
    }
}
