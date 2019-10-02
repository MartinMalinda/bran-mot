using System;
namespace ConcertHall
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            Name = "Violin";
            NumberOfStrings = 4;
            SoundsLike = "Screech";
        }

        public Violin(int stringCount)
        {
            Name = "Violin";
            NumberOfStrings = stringCount;
            SoundsLike = "Screech";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {NumberOfStrings}- stringed instrument that {SoundsLike}");
        }
    }
}
