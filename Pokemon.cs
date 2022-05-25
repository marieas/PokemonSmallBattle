using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public string Type { get; set; }
        public Pokemon(string type, string name, int health)
        {
            Type = type;
            Name = name;
            Health = health;
        }

        public void Attack(Pokemon enemyPokemon)
        {
            Console.WriteLine($"Pokemon {Name} is attacking {enemyPokemon.Name}");
            enemyPokemon.LooseHealth(20000);
        }

        public void LooseHealth(int damage)
        {
            Console.WriteLine($"{Name} `s HP is {Health}");
            Health -= damage;
        }
    }
}
