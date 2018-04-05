using System;
using System.Collections.Generic;

namespace deckcards
{
    class Program
    {

        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            List<Player> Players = new List<Player>();
            Player player1 = new Player("Toto");
            Player player2 = new Player("Thy");

            string Activity;
            DisplayIntrunction();

            System.Console.Write("Please select the option: ");
            Activity = Console.ReadLine();

            while(Activity != "0")
            {
                switch (Activity)
                {
                    case "1":
                        Console.WriteLine("Shuffled");
                        d1.Shuffle(200);
                        break;
                    case "2":
                        Console.WriteLine("Case 2 : Deal?");
                        break;
                    case "3":
                        if (Players.Count > 0) {
                            Console.ForegroundColor = Setting.WarningColor;
                            System.Console.WriteLine("All players are already accepted. Please press 5 to see all players.");
                            Console.ResetColor();
                        } else {
                            Console.Write("Input the number of player (2-6) : ");
                            int NumberOfPlayer = 0;
                            Int32.TryParse(Console.ReadLine(), out NumberOfPlayer);
                            if(NumberOfPlayer >= 2 && NumberOfPlayer <= 6)
                            {
                                Players = GetPlayer(NumberOfPlayer);
                            } else {
                                Console.ForegroundColor = Setting.WarningColor;
                                System.Console.WriteLine("We accept only number 2 to 6.");
                                Console.ResetColor();
                            }
                        }
                        
                        break;
                    case "4":
                        Console.WriteLine("Case 4 : Display all card");
                        d1.ListCard();
                        DisplayIntrunction();
                        break;
                    case "5":
                        Console.WriteLine("Case 5 : Display all players");
                        if(Players.Count > 0)
                        {
                            DisplayPlayer(Players);
                        } else {
                            Console.ForegroundColor = Setting.WarningColor;
                            System.Console.WriteLine("Choose option number 3 to input the player!");
                            Console.ResetColor();
                        }
                        DisplayIntrunction();
                        break;
                    case "9":
                        Console.WriteLine("Case 9 : Reset all card");
                        d1.Reset();
                        
                        break;
                    default:
                        DisplayIntrunction();
                        break;
                }

                System.Console.Write("Please select the option: ");
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
            Console.ForegroundColor =  Setting.MenuColor;

            //Top Line
            WriteSpace(Setting.LeftSpace);
            Write(Setting.UpperLeftCorner);
            WriteLine(Setting.LineWidth);
            Write(Setting.UpperRightCorner);
            System.Console.WriteLine();

            //Line 1
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[0]);
            WriteSpace(Setting.LineWidth - Setting.Menu[0].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 2
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[1]);
            WriteSpace(Setting.LineWidth - Setting.Menu[1].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 3
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[2]);
            WriteSpace(Setting.LineWidth - Setting.Menu[2].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 4
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[3]);
            WriteSpace(Setting.LineWidth - Setting.Menu[3].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 5
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[4]);
            WriteSpace(Setting.LineWidth - Setting.Menu[4].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 6
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[5]);
            WriteSpace(Setting.LineWidth - Setting.Menu[5].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            WriteDashLine();

            //Line 7
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Write(Setting.Menu[6]);
            WriteSpace(Setting.LineWidth - Setting.Menu[6].Length);
            Write(Setting.vertical);
            System.Console.WriteLine();

            //Bottom Line
            WriteSpace(Setting.LeftSpace);
            Write(Setting.LowerLeftCorner);
            WriteLine(Setting.LineWidth);
            Write(Setting.LowerRightCorner);
            System.Console.WriteLine();

            Console.ResetColor();
        }

        public static List<Player> GetPlayer(int num){
            List<Player> Players = new List<Player>();
            string PlayerName = "";
            int Counter = num;
            while (Counter > 0)
            {
                System.Console.Write($"Player {num - Counter + 1} name: ");
                PlayerName = Console.ReadLine().Trim();
                if(PlayerName != "")
                {   
                    Players.Add(new Player(PlayerName));
                    Counter--;
                }
            }
            return Players;
        }

        public static void DisplayPlayer(List<Player> Players)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var Player in Players)
            {
                System.Console.WriteLine($"Player {Player.name}");
            }
            Console.ResetColor();
        }
        //Drawing Utilities
        public static void WriteSpace(int num)
        {
            for (int i = 0; i < num; i++)
            {
                System.Console.Write(" ");
            }
        }
        public static void Write(string str)
        {
            System.Console.Write(str);
        }
        public static void WriteLine(int num)
        {
            for (int i = 0; i < num; i++)
            {

                System.Console.Write(Setting.horizontal);
            }
        }
        public static void WriteDash(int num)
        {
            for (int i = 0; i < num; i++)
            {

                System.Console.Write(Setting.dash);
            }
        }
        public static void WriteDashLine()
        {
            //Dash Line
            WriteSpace(Setting.LeftSpace);
            Write(Setting.vertical);
            Console.ForegroundColor = Setting.DashLineColor;
            WriteDash(Setting.LineWidth);
            Console.ForegroundColor = Setting.MenuColor;
            Write(Setting.vertical);
            System.Console.WriteLine();
        }

        //Drawing Utilities

    }
}
