using System;

namespace human
{
    public class Spider: Monster
    {
        public Spider(string name):base(name){
            this.name = name;
            this.strength = 4;
            this.intelligence = 4;
        }

        public override void Attack(Human player){
            player.health = player.health - (strength * intelligence);
            System.Console.WriteLine($"{player.name} lost {(strength * intelligence)} health and was poisoned! {player.health} hp remaining.");
            player.poisoned += 3;
        }
    }
}