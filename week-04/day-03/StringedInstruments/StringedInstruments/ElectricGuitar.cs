using System;
namespace ConcertHall
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            this.Name = "Electric Guitar";
            this.NumberOfStrings = 6;
            this.SoundsLike = "Twang";
        }
        public ElectricGuitar(int stringCount)
        {
            this.Name = "Electric Guitar";
            this.NumberOfStrings = stringCount;
            this.SoundsLike = "Twang";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {NumberOfStrings}- stringed instrument that {SoundsLike}");
        }
    }
}
