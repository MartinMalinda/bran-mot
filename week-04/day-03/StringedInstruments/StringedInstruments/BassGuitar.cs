using System;
namespace ConcertHall
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            this.Name = "Bass Guitar";
            NumberOfStrings = 4;
            SoundsLike = "Duum-duum-duum";
        }

        public BassGuitar(int stringCount)
        {
            this.Name = "Bass Guitar";
            NumberOfStrings = stringCount;
            SoundsLike = "Duum-duum-duum";
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {NumberOfStrings}- stringed instrument that {SoundsLike}");
        }
    }
}
