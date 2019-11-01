using System;
using System.Collections.Generic;
using System.Linq;
using day05.Interfaces;
using day05.Models;

namespace day05.Services
{
    public class FoxService : IFox
    {
        public List<Fox> FoxList { get; private set; }
        public Fox CurrentFox { get; private set; }

        public FoxService()
        {
            Fox mrFox = new Fox("Mr. Fox");
            mrFox.AddFood("Pizza");
            mrFox.AddFood("Lemonade");
            mrFox.AddTrick("Write HTML");
            mrFox.AddTrick("Code in Java");

            FoxList = new List<Fox>
            {
                mrFox
            };
            ChangeFox("Mr. Fox");
        }

        public void AddFox(string name)
        {
            FoxList.Add(new Fox(name));
        }

        public void ChangeFox(string name)
        {
            CurrentFox = FoxList.First(fox => name == fox.Name);
        }

        public void CheckFox(string name)
        {
            throw new NotImplementedException();
        }

        public Fox GetCurrentFox()
        {
            return CurrentFox;
        }
    }
}
