using System;
namespace ConcertHall
{
    abstract class Instrument
    {
        protected string Name { get; set; }
        public string SoundsLike { get; set; }

        public abstract void Play();
    }
}
