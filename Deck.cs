using System.Collections.Generic;
using System;
using System.Linq;

namespace deckcards {
    public class Deck {
        private static Random _rand;

        public List<Card> Cards = new List<Card>();
        private string[] suits = {"♥", "♦", "♣", "♠"};
        public Deck(){
            _rand = new Random();
            foreach (var suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    
                    Card card = new Card();
                    card.stringVal = (i == 1) ? "A": (i == 11) ? "J" : (i == 12) ? "Q" : (i == 13) ? "K" : $"{i}";
                    card.suit = suit;
                    card.val = i;
                    Cards.Add(card);
                }
            }
        }

        public Card Deal(){
            Card dealCard;
            if(Cards.Count != 0){
                dealCard = Cards[Cards.Count-1];
                Cards.RemoveAt(Cards.Count-1);
                return  dealCard;
                }
            else{
                return null;
            }
        }
        public Card Deal(DiscardPile discard){
            Card dealCard;
            if(Cards.Count == 0){
                Reshuffle(discard);
            }
            if(Cards.Count != 0){
                dealCard = Cards[Cards.Count-1];
                Cards.RemoveAt(Cards.Count-1);
                return  dealCard;
            }
            else{
                return null;
            }
        }

        public void Reset(){
            Cards.Clear();
            foreach (var suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card();
                    card.stringVal = (i == 1) ? "A": (i == 11) ? "J" : (i == 12) ? "Q" : (i == 13) ? "K" : $"{i}";
                    card.suit = suit;
                    card.val = i;
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle(){
            
            for(int i = 0; i < Cards.Count; i++){
                Card tmp = Cards[i];
                int r = _rand.Next(i,Cards.Count);
                Cards[i] = Cards[r];
                Cards[r] = tmp;  //Knuth shuffle algorithm. Very useful. 
            }
        }

        public void Reshuffle(DiscardPile discard){
            foreach(Card card in discard.Cards){
                Cards.Add(card);
                discard.Cards.Remove(card);
            }
            Shuffle();
        }

        public void ListCard(){
            foreach (var card in Cards)
            {

                Console.ForegroundColor = card.Color;

                System.Console.WriteLine();
                Utils.Write(card.suit, 4 + card.stringVal.Length);

                System.Console.WriteLine();
                Utils.Write(card.suit);
                Utils.WriteSpace(1);
                Utils.Write(card.stringVal);
                Utils.WriteSpace(1);
                Utils.Write(card.suit);

                System.Console.WriteLine();
                Utils.Write(card.suit, 4 + card.stringVal.Length);
                // System.Console.WriteLine("♥♥♥♥♥");
                // System.Console.WriteLine("♥ A ♥");
                // System.Console.WriteLine("♥♥♥♥♥");
                // System.Console.Write($" {card.suit} {card.stringVal}");
                // System.Console.WriteLine();

                Console.ResetColor();
                // Console.ForegroundColor = ConsoleColor.Green;
                // System.Console.Write("Card:");

            }
        }

        public void ListCard(int NumPerRow)
        {
            int Counter = this.Cards.Count();
            int Row = 0;
            while(Counter >= NumPerRow * (Row + 1)){
                int StartIndex = Row * NumPerRow;
                int EndIndex = NumPerRow * (Row + 1);

                if(EndIndex >= this.Cards.Count()) {
                    EndIndex = this.Cards.Count() - 1;
                    // System.Console.WriteLine(EndIndex);
                }

                // List<Card> rowCards = this.Cards.GetRange(0, 13);
                IEnumerable<Card> rowCards = this.Cards.Skip(StartIndex).Take(13).Select(c =>c);
 
                System.Console.WriteLine();
                // Line 1
                foreach (var card in rowCards)
                {
                    // Line 1
                    Console.ForegroundColor = card.Color;
                    Utils.Write(card.suit, 4 + card.stringVal.Length);
                    Utils.WriteSpace(2);
                    Console.ResetColor();
                }

                // Line 2
                System.Console.WriteLine();
                foreach (var card in rowCards)
                {
                    Console.ForegroundColor = card.Color;
                    Utils.Write(card.suit);
                    Utils.WriteSpace(1);
                    Utils.Write(card.stringVal);
                    Utils.WriteSpace(1);
                    Utils.Write(card.suit);
                    Utils.WriteSpace(2);
                    Console.ResetColor();
                }

                System.Console.WriteLine();
                foreach (var card in rowCards)
                {
                    Console.ForegroundColor = card.Color;
                    Utils.Write(card.suit, 4 + card.stringVal.Length);
                    Utils.WriteSpace(2);
                    Console.ResetColor();
                }
                System.Console.WriteLine();

                Row++;
            }
            

        }
    }
}