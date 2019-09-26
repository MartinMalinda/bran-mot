using System;
namespace objectsAndClasses
{
    //Station
    //GasAmount
    //Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount
    //Car
    //GasAmount
    //Capacity
    //create constructor for Car where:
    //initialize gasAmount -> 0
    //initialize capacity -> 100
    public class Station
    {
        public int GasAmount { get; set; }

        public Station(int gasAmount)
        {
            this.GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            car.GasAmount += car.Capacity;
            this.GasAmount -= car.Capacity;
            Console.WriteLine($"Station Gas Amount: {this.GasAmount}");
        }
    }

    public class Car
    {
        public int Capacity { get; set; } = 100;
        public int GasAmount { get; set; } = 0;
    }
}
