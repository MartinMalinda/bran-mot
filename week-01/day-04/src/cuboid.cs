using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double length = 7;
            double width = 14;
            double height = 21;

            //surface area 2 × w × l + 2 × l × h + 2 × h × w
            Console.WriteLine("Surface Area: "+   2*width*length + 2*length*height + 2*height*width);

            //volume  l × w × h
            Console.WriteLine("Volume: " + length * width * height);
        }
    }
}