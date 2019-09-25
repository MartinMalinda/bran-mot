using System;
namespace objectsAndClasses
{
    public class Sharpie
    {
        //Create Sharpie class
        //We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
        //When creating one, we need to specify the Color and the Width
        //Every sharpie is created with a default 100 as InkAmount
        //We can Use() the sharpie objects
        //which decreases inkAmount

        public string color { get; set; }
        public double width { get; set; }
        public double inkAmount { get; set; } = 100;

        public Sharpie(string color, double width)
        {
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkAmount--;
            Console.WriteLine($"The sharpie has {inkAmount}% ink left");
        }
    }
}
