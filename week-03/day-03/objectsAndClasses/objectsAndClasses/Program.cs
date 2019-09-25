using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Station chevron = new Station(1000);
            Car honda = new Car();
            Car hyundai = new Car();

            chevron.Refill(honda);
            chevron.Refill(hyundai);

            Console.WriteLine(hyundai.GasAmount);
            Console.WriteLine(honda.GasAmount);

        }
    }
}
