using System;

namespace human
{
    class Samurai : Human
    {
        private static int count = 0;
        public Samurai(string name, int health = 200)
            : base(name)
        {
            count++;
        }

        public void Death_blow(object thing)
        {
            if (thing is Human)
            {
                Human enemy = thing as Human;
                if (enemy.health < 50)
                {
                    enemy.health = 0;
                    Console.WriteLine("{0} has received a death blow! Hp is now 0!",enemy.name);
                }
                else
                {
                    Attack(thing);
                }
            }
            else
            {
                Monster enemy = thing as Monster;
                if (enemy.health < 50)
                {
                    enemy.health = 0;
                    Console.WriteLine("{0} has received a death blow! Hp is now 0!",enemy.name);
                }
                else
                {
                    Attack(thing);
                }
            }

        }

        public void Meditate()
        {
            this.health = 200;
            System.Console.WriteLine("Samurai meditated, Health fully restored");
        }

        public static void How_many()
        {
            System.Console.WriteLine("There are " + count + "samurais in this world.");
        }
    }
}