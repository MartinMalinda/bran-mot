using System;
using System.Collections.Generic;

namespace Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            SortDominoes(dominoes);

        }

        public static void SortDominoes(List<Domino> dominoSet)
        {
            List<Domino> sortedDominoes = new List<Domino>();
            sortedDominoes.Add(dominoSet[0]);
           
            for (int i = 0; i < dominoSet.Count-1; i++)
            {
                int valueToMatch = sortedDominoes[i].GetValues()[1];

                foreach (var domino in dominoSet)
                {
                    if (domino.GetValues()[0] == valueToMatch)
                    {
                        int valA = domino.GetValues()[0];
                        int valB = domino.GetValues()[1];

                        sortedDominoes.Add(new Domino(valA, valB));
                    }
                }
            }
            foreach (var domino in sortedDominoes)
            {
                Console.Write($"[{domino.GetValues()[0]}, {domino.GetValues()[1]}] ");
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}