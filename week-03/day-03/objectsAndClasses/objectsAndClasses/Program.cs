using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", PokemonType.Leaf, PokemonType.Water);
            string pokemonToUse = "";

            // Which pokemon should Ash use?
            foreach (var pokemon in pokemonOfAsh)
            {
                if (pokemon.IsEffectiveAgainst(wildPokemon))
                {
                    pokemonToUse = pokemon.Name;
                }
            }

            Console.Write($"I choose you, {pokemonToUse}");
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", PokemonType.Leaf, PokemonType.Water),
                new Pokemon("Pikatchu", PokemonType.Electric, PokemonType.Water),
                new Pokemon("Charizard", PokemonType.Fire, PokemonType.Leaf),
                new Pokemon("Balbasaur", PokemonType.Water, PokemonType.Fire),
                new Pokemon("Kingler", PokemonType.Water, PokemonType.Fire)
            };
        }
    }
}
