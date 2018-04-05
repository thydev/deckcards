using System;

namespace human
{
    public class Monster
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int health { get; set; }

        public Monster()
        {

        }

        public Monster(string name){
            this.name = name;
            this.strength = 5;
            this.intelligence = 5;
            this.health = 50;
        }

        public Monster(string name, int strength, int intelligence, int health){
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.health = health;
        }
        
        public virtual void Attack(Human player){
            this.health -= 1;
            player.health = player.health - (strength * intelligence);
            System.Console.WriteLine($"{this.name} attacked {player}. {(strength * intelligence)} damages made. Current health: {player.health}");
        }
    }


}