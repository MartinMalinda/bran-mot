using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("The color is Red");
        }
    }

   

    public class YellowColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("The color is Yellow");
        }
    }
}
