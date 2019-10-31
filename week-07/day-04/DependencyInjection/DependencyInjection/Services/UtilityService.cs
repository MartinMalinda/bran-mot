using System;
using System.Collections.Generic;

namespace DependencyInjection.Services
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public bool CheckEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }

        public string Caesar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }
    }
}
