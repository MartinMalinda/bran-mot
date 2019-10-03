using System;
using System.Collections.Generic;
namespace objectsAndClasses
{
    //Reuse your Sharpie class
    //Create SharpieSet class
    //it contains a list of Sharpie
    //Add method CountUsable() -> sharpie is usable if it has ink in it
    //Add method RemoveTrash() -> removes all unusable sharpies
    public class SharpieSet
    {
        public List<Sharpie> sharpieSet { get; set; }

        public SharpieSet()
        {
            sharpieSet = new List<Sharpie>();
        }

        public void AddSharpie(Sharpie sharpie)
        {
            sharpieSet.Add(sharpie);
        }

        public void CountUsable()
        {
            int usableSharpies = 0;
            foreach (Sharpie sharpie in sharpieSet)
            {
                if (sharpie.inkAmount > 0)
                {
                    usableSharpies++;
                }
            }
            Console.WriteLine($"You have {usableSharpies} usable sharpies");
        }

        public void Removetrash()
        {
            int toThrowAway = 0;
            for (int i = sharpieSet.Count-1; i >= 0; i--)
            {
                if (sharpieSet[i].inkAmount.CompareTo(0.0) == 0)
                {
                    toThrowAway++;
                    sharpieSet.Remove(sharpieSet[i]);
                }
            }
            Console.WriteLine($"{toThrowAway} sharpies have been thrown away. There are {sharpieSet.Count} sharpies remaining.");
        }
    }
}
