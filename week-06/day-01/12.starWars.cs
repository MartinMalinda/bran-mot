using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Linq
{
    class Character
    {
        public string Name { get; private set; }
        public int Height { get; private set; }
        public int Mass { get; private set; }
        public string HairColor { get; private set; }
        public string SkinColor { get; private set; }
        public string EyeColor { get; private set; }
        public int BirthYear { get; private set; }
        public string Gender { get; private set; }

        public Character(string name, string height, string mass, string hairColor, string skinColor, string eyeColor, string birthYear, string gender)
        {
            
            Name = name;
            if (Int32.TryParse(height, out int heightValue))
            {
                Height = heightValue;
            }
            if (Int32.TryParse(mass, out int massValue))
            {
                Mass = massValue;
            }
            if (hairColor != "n/a")
            {
                HairColor = hairColor;
            }
            if (skinColor != "n/a")
            {
                SkinColor = skinColor;
            }
            if (eyeColor != "n/a")
            {
                EyeColor = eyeColor;
            }
            if (Int32.TryParse(birthYear.Substring(0, 2), out int birthYearValue))
            {
                BirthYear = birthYearValue;
            }
            if (gender != "unknown" || gender != "n/a")
            {
                Gender = gender;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List < Character > starWarsPeople = new List<Character>();
            var characterSource = File.ReadAllLines(@"./swcharacters.csv");
            
            foreach (var character in characterSource)
            {
                var characterProperties = character.Split(new char[] { ';' });
                starWarsPeople.Add(new Character(characterProperties[0], characterProperties[1], characterProperties[2], characterProperties[3], characterProperties[4], characterProperties[5], characterProperties[6], characterProperties[7]));
            }
            var heaviestCharacter = starWarsPeople.OrderByDescending(character => character.Mass).First();
            Console.WriteLine(heaviestCharacter.Name);

            var averageMaleHeight = starWarsPeople.Where(character => character.Gender == "male").Average(character => character.Height);
            Console.WriteLine(averageMaleHeight);

            var averageFemaleHeight = starWarsPeople.Where(character => character.Gender == "female").Average(character => character.Height);
            Console.WriteLine(averageFemaleHeight);
        }
    }
}
