using System;

namespace deckcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Player player1 = new Player("Toto");
            Player player2 = new Player("Thy");

            string Activity;
            DisplayIntrunction();
            // Int32.TryParse(Console.ReadLine(), out Activity);
            Activity = Console.ReadLine();

            while(Activity != "0")
            {
                switch (Activity)
                {
                    case "1":
                        Console.WriteLine("Shuffled");
                        d1.shuffle(200);
                        break;
                    case "2":
                        Console.WriteLine("Case 2 : Deal?");
                        break;
                    case "3":
                        Console.WriteLine("Case 3");
                        break;
                    case "4":
                        Console.WriteLine("Case 4 : Display all card");
                        d1.listCard();
                        DisplayIntrunction();
                        break;
                    case "9":
                        Console.WriteLine("Case 9 : Reset all card");
                        d1.reset();
                        
                        break;
                    default:
                        DisplayIntrunction();
                        break;
                }
                Activity = Console.ReadLine();
            }
            

            // System.Console.WriteLine(d1.cards[0].stringVal + d1.cards[0].suit);
            // d1.listCard();
            // System.Console.WriteLine("Shuffling....");
            // d1.shuffle(100);
            // d1.listCard();

            // // System.Console.WriteLine( d1.deal().stringVal );
            // // System.Console.WriteLine( d1.deal().stringVal);
            // // System.Console.WriteLine( d1.deal().stringVal);

            // player1.draw(d1);
            // player2.draw(d1);
            // player1.draw(d1);
            // player2.draw(d1);

            // System.Console.WriteLine(d1.cards.Count);
            // player1.listCard();
            // player2.listCard();

            // System.Console.WriteLine(player1.discard(0));
            // System.Console.WriteLine(player2.discard(1));
            // System.Console.WriteLine(player1.discard(1));//null
            // System.Console.WriteLine(player2.discard(1)); //null
            
            // d1.reset();

        }

        public static void DisplayIntrunction()
        {
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("1 : Shuffle");
            System.Console.WriteLine("2 : Deal");
            System.Console.WriteLine("3 : Input the number of players");
            System.Console.WriteLine("4 : Display all cards");
            System.Console.WriteLine("9 : Reset all cards");
            System.Console.WriteLine("0 : Exit");
        }
    }
}
