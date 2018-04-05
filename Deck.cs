using System.Collections.Generic;
using System;
namespace deckcards {
    public class Deck {
        private static Random _rand;

        public List<Card> Cards = new List<Card>();
        private string[] suits = {"♥", "♦", "♣", "♠"};
        public Deck(){
            foreach (var suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    
                    Card card = new Card();
                    card.stringVal = (i == 1) ? "Ace": (i == 11) ? "Jack" : (i == 12) ? "Queen" : (i == 13) ? "King" : $"{i}";
                    card.suit = suit;
                    card.val = i;
                    Cards.Add(card);
                }
            }
        }

        public Card Deal(){
            Card dealCard;
            dealCard = Cards[Cards.Count-1];
            Cards.RemoveAt(Cards.Count-1);
            return  dealCard;
        }

        public void Reset(){
            Cards.Clear();
            foreach (var suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card();
                    card.stringVal = (i == 1) ? "Ace": (i == 11) ? "Jack" : (i == 12) ? "Queen" : (i == 13) ? "King" : $"{i}";
                    card.suit = suit;
                    card.val = i;
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle(int num){
            _rand = new Random();
            for (int i = 0; i < num; i++)
            {
                int idx1 = _rand.Next(0, Cards.Count);
                int idx2 = _rand.Next(0, Cards.Count);
                Card tmp = new Card();
                tmp = Cards[idx1];
                Cards[idx1] = Cards[idx2];
                Cards[idx2] = tmp;
            }
        }

        public void ListCard(){
            foreach (var card in Cards)
            {
                // System.Console.WriteLine($"Card: {card.suit} {card.stringVal}");
                Console.ForegroundColor = card.Color;
                System.Console.Write("Card:");
                System.Console.Write($" {card.suit} {card.stringVal}");
                System.Console.WriteLine();

                Console.ResetColor();
                // Console.ForegroundColor = ConsoleColor.Green;
                // System.Console.Write("Card:");

            }
        }
    }
}