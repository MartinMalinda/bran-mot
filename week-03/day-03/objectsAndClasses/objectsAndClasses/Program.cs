using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pirate John = new Pirate("John");
            Pirate Marty = new Pirate("Marty");


            Console.WriteLine();
            John.DrinkSomeRum();

            Console.WriteLine();
            John.Brawl(Marty);

            PirateShip myShip = new PirateShip();


            myShip.AddPirate(Marty, "crew");
            myShip.AddPirate(John, "captain");
            myShip.AddPirate(John, "captain");

            myShip.ShipStatus();

        }
    }
}
