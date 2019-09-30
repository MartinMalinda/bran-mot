using System;
namespace trialExam
{
    public class Pirate
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int HealthPoints { get; set; } = 10;
        public bool IsCaptain { get; }
        public bool HasWoodenLeg { get; }

        public Pirate(string name)
        {
            this.Name = name;
        }
        public Pirate(string name, bool captain, bool woodenLeg)
        {
            this.Name = name;
            if (captain == true && woodenLeg == true)
            {
                this.HasWoodenLeg = true;
                this.IsCaptain = true;
            }
            else if(captain == true && woodenLeg == false)
            {
                this.IsCaptain = true;
            }
            else if(captain == false && woodenLeg == true)
            {
                this.HasWoodenLeg = true;
            }
        }

        public void Work()
        {
            if(IsCaptain == true)
            {
                Gold += 10;
                HealthPoints -= 5;
            }
            else
            {
                Gold++;
                HealthPoints--;
            }
            Console.WriteLine($"{Name} worked. Current gold: {Gold}, Current health: {HealthPoints}");
            Console.WriteLine();
        }

        public void Party()
        {
            if (IsCaptain == true)
            {
                HealthPoints += 10;
            }
            else
            {
                HealthPoints++;
            }
            Console.WriteLine($"{Name} partied. Current health: {HealthPoints}");
            Console.WriteLine();
        }
            
        public string ToString()
        {
            string pirateResponse = "";
            if(HasWoodenLeg == true)
            {
                pirateResponse = $"Hello, I'm {Name}. I have a wooden leg and {Gold} golds.";
            }
            else
            {
                pirateResponse = $"Hello, I'm {Name}. I still have my real legs and {Gold} golds.";
            }
            return pirateResponse;
        }
    }
}
