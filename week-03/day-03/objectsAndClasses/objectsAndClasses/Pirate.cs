using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    //Create a Pirate class. While you can add other fields and methods, you must have these methods:-
    //DrinkSomeRum() - intoxicates the Pirate some
    //HowsItGoingMate() - when called, the Pirate replies, if DrinkSomeRun was called:-
    //0 to 4 times, "Pour me anudder!"
    //else, "Arghh, I'ma Pirate. How d'ya d'ink its goin?", the pirate passes out and sleeps it off.
    //If you manage to get this far, then you can try to do the following.

    //Die() - this kills off the pirate, in which case, DrinkSomeRum, etc.just result in he's dead.
    //Brawl(x) - where pirate fights another pirate (if that other pirate is alive) and there's a 1/3 chance, 1 dies, the other dies or they both pass out.
    //And... if you get that far...

    //Add a parrot.

    public class Pirate
    {
        public string name { get; set; }
        public int intoxication { get; set; } = 0;
        public int replies { get; set; } = 0;
        public bool PassedOut { get; set; } = false;
        public bool dead { get; set; } = false;
        public bool isCaptain { get; set; } = false;
        private string passedOutMessage = "He's passed out. ZZZzzZZzzZZZ";

        public Pirate(string name)
        {
            this.name = name;
        }

        public void DrinkSomeRum()
        {
            if (PassedOut)
            {
                Console.WriteLine(passedOutMessage);
            }
            else if (intoxication == 4)
            {
                intoxication++;
                Console.WriteLine($"{name} drank some rum and passed out.");
            }
            intoxication++;
            Console.WriteLine($"{name} drank some rum.");
        }

        public void HowsItGoingMate()
        {
            if (PassedOut == true)
            {
                Console.WriteLine(passedOutMessage);
            }
            else if (intoxication > 4)
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                DrinkSomeRum();
            }
            else
            {
                Console.WriteLine("Pour me anudder!");
                DrinkSomeRum();
            }
        }

        public void Die()
        {
            dead = true;
            Console.WriteLine($"{name} is dead.");
        }

        public void Brawl(Pirate opponent)
        {
            Random randomNumber = new Random();
            int fightResult = randomNumber.Next(1, 4);
            if (dead == true || opponent.dead == true)
            {
                Console.WriteLine("The dead can't fight!");
            }
            switch (fightResult)
            {
                case 1:
                    Die();
                    break;
                case 2:
                    opponent.Die();
                    break;
                default:
                    PassedOut = true;
                    opponent.PassedOut = true;
                    Console.WriteLine("Both pirates passed out!");
                    break;
            }
        }
    }

    //Create a Ship class.
    //The Ship stores Pirate-s instances in a list as the crew and has one captain who is also a Pirate.
    //When a ship is created it doesn't have a crew or a captain.
    //The ship can be filled with pirates and a captain via FillShip() method.
    //Filling the ship with a captain and random number of pirates.
    //Ships should be represented in a nice way on command line including information about
    //captains consumed rum, state (passed out / died)
    //number of alive pirates in the crew
    //Ships should have a method to battle other ships: ship.Battle(otherShip)
    //should return true if the actual ship(this) wins
    //the ship should win if its calculated score is higher
    //calculate score: Number of Alive pirates in the crew - Number of consumed rum by the captain
    //The loser crew has a random number of losses(deaths).
    //The winner captain and crew has a party, including a random number of rum :)
    public class PirateShip
    {
        public List<Pirate> pirateShip { get; set; }
        public bool hasCaptain { get; set; } = false;

        public PirateShip()
        {
            pirateShip = new List<Pirate>();
        }

        public void AddPirate(Pirate pirate, string crewOrCaptain)
        {
            if(crewOrCaptain == "captain")
            {
                if (hasCaptain == true)
                {
                    Console.WriteLine("The ship already has a captain.");
                    Console.WriteLine();
                }
                else
                {
                    pirateShip.Insert(0, pirate);
                    hasCaptain = true;
                    Console.WriteLine($"{pirate.name} was added as the ship's captain");
                    Console.WriteLine();
                    pirate.isCaptain = true;
                }
            }
            else
            {
                pirateShip.Add(pirate);
                Console.WriteLine($"{pirate.name} was added to the ship's crew!");
            } 
        }

        public void AddCaptain(Pirate pirate)
        {
            
            
        }

        public void ShipStatus()
        {
            if(pirateShip.Count > 0)
            {
                Console.WriteLine("Pirateship Crew");
                Console.WriteLine("===============");
                foreach (Pirate pirate in pirateShip)
                {
                    string status = "alive";
                    if (pirate.PassedOut == true)
                    {
                        status = "passed out";
                    }
                    else if (pirate.dead == true)
                    {
                        status = "dead";
                    }
                    Console.WriteLine($"{pirate.name}, Intoxication: {pirate.intoxication}, Status: {status}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The ship is empty");
                Console.WriteLine();
            }
        }
    }
}
