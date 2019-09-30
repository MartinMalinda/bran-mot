using System;
using System.IO;
using System.Collections.Generic;

namespace trialExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate Jack = new Pirate("Jack");
            Pirate Jill = new Pirate("Jill", true, true);
            Pirate John = new Pirate("John", false, true);

            Jack.Work();
            Jill.Work();
            John.Work();

            Jack.Party();
            Jill.Party();
            John.Party();

            Console.WriteLine(Jack.ToString());
            Console.WriteLine(Jill.ToString());
            Console.WriteLine(John.ToString());

            PirateShip myShip = new PirateShip();

            myShip.AddPirate(Jill);
            myShip.AddPirate(Jack);
            myShip.AddPirate(John);


            Console.WriteLine(myShip.GetPoorPirates());
            Console.WriteLine(myShip.GetGolds());

            //myShip.LastDayOnTheShip();

            myShip.PrepareForBattle();

        }
    }
}
