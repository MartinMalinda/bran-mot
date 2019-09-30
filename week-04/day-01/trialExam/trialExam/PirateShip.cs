using System;
using System.Collections.Generic;
namespace trialExam
{
    //It should have a list of pirates.
    //You must be able to add new pirates to the ship.It must have only one captain!
    //You must create the following methods:
    //getPoorPirates() which returns a list of names containing the pirates that
    //have a wooden leg and have less than 15 golds
    //getGolds() which returns the sum of gold owned by the pirates of that particular ship
    //lastDayOnTheShip() which calls the pirates' party() method.
    //prepareForBattle() which calls
    //the pirates' work() method 5 times
    //then the ship's lastDayOnTheShip() method.
    public class PirateShip
    {
        public List<Pirate> Ship { get; set; }
        public bool HasCaptain { get; set; } = false;

        public PirateShip()
        {
            Ship = new List<Pirate>();
        }

        public void AddPirate(Pirate pirate)
        {
            if(this.HasCaptain == true && pirate.IsCaptain)
            {
                Console.WriteLine("The ship already has a captain.");
            }
            else if(this.HasCaptain == false && pirate.IsCaptain == true)
            {
                Ship.Add(pirate);
                Console.WriteLine($"{pirate.Name} was added to the ship as captain!");
                HasCaptain = true;
                Console.WriteLine();
            }
            else
            {
                Ship.Add(pirate);
                Console.WriteLine($"{pirate.Name} was added to the ship!");
                Console.WriteLine();
            }
        }

        public string GetPoorPirates()
        {
            string poorPirates = "Poor Pirates List \n" +
                                 "=================\n";
            foreach (var pirate in Ship)
            {
                if (pirate.HasWoodenLeg == true && pirate.Gold < 15)
                {
                    poorPirates = poorPirates + pirate.Name + "\n";
                }
            }
            return poorPirates;
        }

        public string GetGolds()
        {
            int totalGold = 0;
            foreach (var pirate in Ship)
            {
                totalGold += pirate.Gold;
            }
            return $"The ship has {totalGold} total gold on board";
        }

        public void LastDayOnTheShip()
        {
            foreach (var pirate in Ship)
            {
                pirate.Party();
            }
        }

        public void PrepareForBattle()
        {
            int timesToWork = 5;
            for (int workCycles = 0; workCycles < timesToWork; workCycles++)
            {
                foreach (var pirate in Ship)
                {
                    pirate.Work();
                }
            }
            LastDayOnTheShip();
        }
    }
}
