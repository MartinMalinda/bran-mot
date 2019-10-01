using System;
using System.Collections.Generic;

namespace People 
{
    class Person
    {
        public int Age;
        public string Name;
    }
}

namespace inhertiance 
{
    class Aircraft
    {
        public int CurrentAmmo { get; set; } = 0;
        public int BaseDamage { get; set; }
        public int MaxAmmo { get; set; }
        public bool ammoPriority { get; set; }

        public Aircraft()
        {
        }

        public void Fight()
        {
            if (CurrentAmmo > 0)
            {
                Console.WriteLine($"Damage dealt: {MaxAmmo * BaseDamage}");
                CurrentAmmo = 0;
            }
            else
            {
                Console.WriteLine("No ammo for a fight");
            }
            
        }

        public int Refill(int ammo)
        {
            for (int i = CurrentAmmo; i < MaxAmmo; i++)
            {
                ammo--;
                CurrentAmmo++;
            }
            return ammo;
        }

        public string GetAircraftType()
        {
            string typeOfObject = this.GetType().ToString();
            return typeOfObject;
        }

        public string GetStatus()
        {
            return $"Type: {GetType()}, Ammo: {CurrentAmmo}, Base Damage: {BaseDamage}, All Damage: {BaseDamage * CurrentAmmo}"; 
        }

        public string IsPriority()
        {
            if (ammoPriority)
            {
                return "This aircraft has ammo fill queue priority";
            }
            else
            {
                return "This aircraft does not have ammo fill queue priority";
            }
        }
    }
    class F16 : Aircraft
    {
        public F16()
        {
            this.BaseDamage = 30;
            this.MaxAmmo = 8;
            ammoPriority = false;
        }
    }
    class F35 : Aircraft
    {
        public F35()
        {
            this.BaseDamage = 50;
            this.MaxAmmo = 12;
            ammoPriority = true;
        }
    }
    class Carrier
    {
        public int AmmoStore { get; set; }
        public int Health { get; set; }
        public int RequiredAmmo { get; set; }
        public int TotalDamage { get; set;  }
        public List<Aircraft> Aircrafts { get; set; }

        public Carrier(int initialAmmo, int health)
        {
            Aircrafts = new List<Aircraft>();
            this.AmmoStore = initialAmmo;
            this.Health = health;
        }

        public void Add(Aircraft aircraft)
        {
            if (aircraft.ammoPriority)
            {
                Aircrafts.Insert(0, aircraft);
            }
            else
            {
                Aircrafts.Add(aircraft);
            }
            RequiredAmmo += aircraft.MaxAmmo;
            TotalDamage += aircraft.MaxAmmo * aircraft.BaseDamage;
        }

        public void Fill()
        {
            if (AmmoStore >= RequiredAmmo)
            {
                foreach (var aircraft in Aircrafts)
                {
                    aircraft.Refill(AmmoStore);
                }
            } else if(AmmoStore < RequiredAmmo && AmmoStore > 0)
            {
                int counter = 0;
                while(AmmoStore > 0)
                {
                    Aircrafts[counter].Refill(AmmoStore);
                    counter++;
                }
            }
            else
            {
                throw new Exception("There's no ammo in the Ammo Store");
            }
        }
        public void Fight(Carrier enemyCarrier)
        {
            int totalDamage = 0;
            foreach (var aircraft in Aircrafts)
            {
                totalDamage += (aircraft.CurrentAmmo * aircraft.BaseDamage);
                aircraft.CurrentAmmo = 0;
            }
            enemyCarrier.Health -= totalDamage;
        }
        public string GetStatus()
        {
            string status = "";

            status = $"HP: {Health}, Aircraft Count: {Aircrafts.Count}, Ammo Storage: {AmmoStore}, Total Damage: {TotalDamage} \n Aircrafts: \n";
            foreach (var aircraft in Aircrafts)
            {
                status = status + $"{aircraft.GetType()}, Ammo: {aircraft.CurrentAmmo}, Base Damage: {aircraft.BaseDamage}, All Damage: {aircraft.BaseDamage * aircraft.MaxAmmo}\n";
            }
            if(Health <= 0)
            {
                status = status + "It's dead Jim :(";
            }
            return status;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F16 F16 = new F16();
            F35 F35= new F35();

            Console.WriteLine(F35.GetType());
            Console.WriteLine(F35.GetStatus());
            Console.WriteLine(F35.IsPriority());
            F35.Fight();
            Console.WriteLine(F35.Refill(200));

            Console.WriteLine();

            Console.WriteLine(F16.GetType());
            Console.WriteLine(F16.GetStatus());
            Console.WriteLine(F16.IsPriority());
            F16.Fight();
            Console.WriteLine(F16.Refill(200));

            Carrier goodGuys = new Carrier(5000, 5000);
            goodGuys.Add(new F16());
            goodGuys.Add(new F16());
            goodGuys.Add(new F16());
            goodGuys.Add(new F16());
            goodGuys.Add(new F16());
            goodGuys.Fill();
            
            Carrier badGuys = new Carrier(50, 1000);

            goodGuys.Fight(badGuys);
            Console.WriteLine(goodGuys.GetStatus());
        }
    }
}
