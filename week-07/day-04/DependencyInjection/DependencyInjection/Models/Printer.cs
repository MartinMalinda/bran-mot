using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class Printer 
    {

        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
