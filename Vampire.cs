using System;

namespace human
{
    public class Vampire : Monster
    {
        //Vampire has a special power: When they attack they can heal themselves(the half of damages they dealth with)
        public Vampire(string name):base(name){
            this.name = name;
            this.strength = 5;
            this.intelligence = 7;
        }

        public override void Attack(Human player){
            this.health += (this.strength * this.intelligence)/2;
            player.health = player.health - (strength * intelligence);
            System.Console.WriteLine($"{this.name} attacked {player}. {(strength * intelligence)} damages made. Current health: {player.health}");
        }
    }
}