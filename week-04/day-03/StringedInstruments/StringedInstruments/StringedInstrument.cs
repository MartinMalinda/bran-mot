using System;
namespace ConcertHall
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("toot toot.");
        }

        public override void Play()
        {
            Sound();
        }
    }
}
