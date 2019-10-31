using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class BlueColor : IColor
    {
        private Printer printer;

        public BlueColor(Printer printer)
        {
            this.printer = printer;
        }

        public void PrintColor()
        {
            printer.Log("This color is blue, sucka.");
        }
    }
}
