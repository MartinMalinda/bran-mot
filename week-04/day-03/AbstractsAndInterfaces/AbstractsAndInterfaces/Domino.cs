using System;
using System.Diagnostics.CodeAnalysis;

namespace AbstractsAndInterfaces
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return values;
        }

        int IComparable<Domino>.CompareTo(Domino other)
        {
            return this.values[0].CompareTo(other.values[0]);
        }
    }
}