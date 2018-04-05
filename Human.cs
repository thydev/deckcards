using System;

namespace human
{
    public class Human
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public int poisoned {get; set;}

        public Human(){

        }
        public Human(string name)
        {
            this.name = name;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public void Attack(object enemy)
        {
            if(enemy is Human){
                Human myenemy = enemy as Human;
                myenemy.health -= (this.strength * 5);
                Console.WriteLine("{0} lost {1} hp! {2} remaining.",myenemy.name,5*this.strength,myenemy.health);
            }
            else{
                Monster myenemy = enemy as Monster;
                myenemy.health -= (this.strength * 5);
                Console.WriteLine("{0} lost {1} hp! {2} remaining.",myenemy.name,5*this.strength,myenemy.health);
            }
            
          
        }

        //boxing unboxing
        // public void Attack2(object p1)
        // {
        //     Human enemy = p1 as Human;
        //     if(enemy == null){
        //         System.Console.WriteLine("Failed Attack");
        //     }
        //     else{
        //         enemy.health -= strength*5;
        //         System.Console.WriteLine("Attaced the enemy, enemy's health decresed by "+  strength*5 + " Current enemy's health "+ enemy.health);
        //     }
        // }

        

        public override string ToString()
        {
            return "Name: " + name + " Strength: " + strength + " Intelligence: " + intelligence + " Dexterity: " + dexterity + " Health: " + health;
        }
    }
}