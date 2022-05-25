using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Player
    {      
        public string Name { get; set; }
        public string Gender { get; set; }       
        public List<Pokemon> PokemonList { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name)
        {
            Name = name;
            PokemonList = new List<Pokemon>(6);
            PokemonList.Add(new Pokemon("Grass", "Weedle", int.MaxValue));
        }

       // Velg en random av de til å sloss med en player pokemon til en av dem har dødd

        public string Menu()
        {
            Console.WriteLine("Fight: 1  Use Item: 2  Flee: 3");
            return Console.ReadLine();
        }
        public void Fight(Pokemon enemyPokemon)
        {
            var playerPokemon = PokemonList[0];
           while(enemyPokemon.Health > 0 && playerPokemon.Health > 0)
           {
               var menuChoice = Menu();
                if(menuChoice == "1")
                {
                    playerPokemon.Attack(enemyPokemon);
                    enemyPokemon.Attack(playerPokemon);
                }
           }

            Console.WriteLine("Enemy died");
        }
        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
        }
        public void Walk()
        {

        }

        public Item GetItemFromInventory()
        {
            return Inventory[0];
        }


    }
}
