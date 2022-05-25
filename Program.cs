using System;
using System.Collections.Generic;

namespace Objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lag en liste av pokemon man kan møte når man går i grasset
            // Velg en random av de til å sloss med en player pokemon til en av dem har dødd

            var player = new Player("Bjarne");
            PlayerWalksInGrass(player);
        }

        public static void PlayerWalksInGrass(Player player)
        {
            var pokemonInGrass = new List<Pokemon>();
            pokemonInGrass.Add(new Pokemon("Normal","Snorlax", 10000));
            pokemonInGrass.Add(new Pokemon("Fire", "Charmander", 4000));
            pokemonInGrass.Add(new Pokemon("Water", "Magicarp", 40000));
            pokemonInGrass.Add(new Pokemon("Ghost", "Gengar", 100000));
            pokemonInGrass.Add(new Pokemon("Normal", "Ditto", 2000000));

            var random = new Random();
            int index = random.Next(pokemonInGrass.Count);
            var randPokemon = pokemonInGrass[index];

            player.Fight(randPokemon);


        }
    }
}
