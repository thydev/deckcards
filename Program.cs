using System;
using System.Collections.Generic;

namespace deckcards
{
    class Program
    {
        private static Random _rand;
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            List<Player> Players = new List<Player>();

            string Activity;
            d1.ListCard(13);
            DisplayIntrunction();
            d1.ListCard(13);
            System.Console.Write("Please select the option: ");
            Activity = Console.ReadLine();

            while(Activity != "0")
            {
                switch (Activity)
                {
                    case "shuffle":
                        Console.WriteLine("Shuffled");
                        d1.Shuffle();
                        break;

                    case "2-autot":
                        Console.WriteLine("Case 2 : Deal?");
                        break;

                    case "inputnumberofplayer":
                        if (Players.Count > 0) {
                            Utils.WriteWarning("All players are already accepted. Please press 5 to see all players.");
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
                    case "1":
                        System.Console.Write($"Player name: ");
                        string PlayerName = Console.ReadLine().Trim();
                        if(PlayerName != "")
                        {   
                            Players.Add(new Player(PlayerName));

                        } else {
                            Utils.WriteWarning("Can not accept empty or space name !!!!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Case 4 : Display all card");
                        // d1.ListCard();
                        DisplayIntrunction();
                        d1.ListCard(13);
                        break;

                    case "5":
                        Console.WriteLine("Case 5 : Display all players");
                        if(Players.Count > 0)
                        {
                            DisplayPlayer(Players);
                        } else {
                            Utils.WriteWarning("Choose option number 3 to input the player!");
                        }
                        DisplayIntrunction();
                        break;

                    case "6":
                        Console.WriteLine("Case 6 : Start ");
                        d1.Shuffle();
                        AssignCards(d1, Players[0], 5);

                        if(Players.Count > 0)
                        {
                            DisplayPlayerMenu();
                            Player p = Players[0];
                            p.ListCard(p.hand.Count);
                            int MonsterHP = 300;
                            int Energy = 5;
                            System.Console.WriteLine($"Player HP: {p.HP}");
                            System.Console.WriteLine("Energy: " + Energy);
                            System.Console.WriteLine("Monster HP: " + MonsterHP);
                            System.Console.Write($"Player {Players[0].name}'s option: ");
                            string PlayerChoice = Console.ReadLine();
                            while(PlayerChoice != "0")
                            {
                                switch (PlayerChoice)
                                {
                                    case "0":
                                        
                                        break;
                                    case "1":
                                    case "2":
                                    case "3":
                                    case "4":
                                    case "5":
                                        if (p.hand.Count > 0 && Energy > 0)
                                        {
                                            if (Int32.Parse(PlayerChoice) > p.hand.Count){
                                                Utils.WriteWarning("There is not card in the option");
                                            } else {
                                                Card c = p.hand[Int32.Parse(PlayerChoice) - 1];
                                                if (Energy < c.EnergyCost) {
                                                    Utils.WriteWarning("You don't have enough energy to use this card");
                                                } else {
                                                    Energy -= c.EnergyCost;
                                                    MonsterHP -= c.Damage;
                                                    p.discard(Int32.Parse(PlayerChoice) - 1);
                                                    if (MonsterHP <= 0) {
                                                        System.Console.WriteLine("You won !");
                                                    }
                                                    System.Console.WriteLine($"Player HP: {p.HP}");
                                                    System.Console.WriteLine("Energy: " + Energy);
                                                    System.Console.WriteLine("Monster HP: " + MonsterHP);
                                                    p.ListCard(p.hand.Count);
                                                }
                                            }
                                            
                                        } else {
                                            if (p.hand.Count <= 0)
                                            {
                                                Utils.WriteWarning("There is anymore card to attack.");
                                            }
                                            if (Energy <= 0)
                                            {
                                                Utils.WriteWarning("No more energy.");
                                            }
                                            Utils.WriteWarning("Monster is attacking.... !@3!!?");
                                            Utils.WriteWarning("I got attacked !");
                                            _rand = new Random();
                                            p.HP -= _rand.Next(180, 210);
                                            if(p.HP <= 0) {
                                                Utils.WriteWarning($"You lost ! Your current HP : {p.HP}");
                                            } else {
                                                Utils.WriteWarning($"Your current HP : {p.HP}");
                                            }
                                        }
                                        break;
                                }
                                System.Console.Write($"Player {Players[0].name}'s option: ");
                                PlayerChoice = Console.ReadLine();
                                if (PlayerChoice == "0" && Energy > 0){
                                    Utils.WriteWarning("Monster is attacking.... !@3!!?");
                                    Utils.WriteWarning("I got attacked !");
                                    _rand = new Random();
                                    p.HP -= _rand.Next(180, 210);
                                    if(p.HP <= 0) {
                                        Utils.WriteWarning($"You lost ! Your current HP : {p.HP}");
                                    } else {
                                        Utils.WriteWarning($"Your current HP : {p.HP}");
                                    }
                                }
                            }
                            
                            p.hand.Clear();
                            d1.Reset();
                            d1.Shuffle();

                            DisplayIntrunction();
                        } else {
                            Utils.WriteWarning("Input your name first!!!");
                        }
                        
                        break;

                    case "9":
                        Console.WriteLine("Case 9 : Reset all card");
                        d1.Reset();
                        
                        break;
                    default:
                        DisplayIntrunction();
                        break;
                }
                System.Console.WriteLine();
                System.Console.Write("Please select the option: ");
                Activity = Console.ReadLine();
            }

        }

        public static void DisplayIntrunction()
        {
            Console.ForegroundColor =  Setting.MenuColor;
            System.Console.WriteLine();
            //Top Line
            Utils.WriteSpace(Setting.LeftSpace);
            Utils.Write(Setting.UpperLeftCorner);
            Utils.WriteLine(Setting.LineWidth);
            Utils.Write(Setting.UpperRightCorner);
            System.Console.WriteLine();

            //Display the main mene
            for (int i = 0; i < Setting.Menu.Length; i++)
            {
                Utils.WriteSpace(Setting.LeftSpace);
                Utils.Write(Setting.vertical);
                Utils.Write(Setting.Menu[i]);
                Utils.WriteSpace(Setting.LineWidth - Setting.Menu[i].Length);
                Utils.Write(Setting.vertical);
                System.Console.WriteLine();

                if (i < Setting.Menu.Length - 1)
                {
                    Utils.WriteDashLine();
                }
            }

            //Bottom Line
            Utils.WriteSpace(Setting.LeftSpace);
            Utils.Write(Setting.LowerLeftCorner);
            Utils.WriteLine(Setting.LineWidth);
            Utils.Write(Setting.LowerRightCorner);
            System.Console.WriteLine();

            Console.ResetColor();
        }

        public static void DisplayPlayerMenu()
        {
            Console.ForegroundColor =  Setting.MenuColor;
            System.Console.WriteLine();
            //Top Line
            Utils.WriteSpace(Setting.LeftSpace);
            Utils.Write(Setting.UpperLeftCorner);
            Utils.WriteLine(Setting.LineWidth);
            Utils.Write(Setting.UpperRightCorner);
            System.Console.WriteLine();

            //Display the main mene
            for (int i = 0; i < Setting.MenuPlayer.Length; i++)
            {
                Utils.WriteSpace(Setting.LeftSpace);
                Utils.Write(Setting.vertical);
                Utils.Write(Setting.MenuPlayer[i]);
                Utils.WriteSpace(Setting.LineWidth - Setting.MenuPlayer[i].Length);
                Utils.Write(Setting.vertical);
                System.Console.WriteLine();

                if (i < Setting.MenuPlayer.Length - 1)
                {
                    Utils.WriteDashLine();
                }
            }

            //Bottom Line
            Utils.WriteSpace(Setting.LeftSpace);
            Utils.Write(Setting.LowerLeftCorner);
            Utils.WriteLine(Setting.LineWidth);
            Utils.Write(Setting.LowerRightCorner);
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
        
        public static void AssignCards(Deck deck, Player player, int numberCard)
        {   
            for (int i = 0; i < numberCard; i++)
            {
                player.draw(deck);
            }
        }

    }
}
