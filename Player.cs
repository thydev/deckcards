using System;
using System.Collections.Generic;
using System.Linq;

namespace deckcards {
    public class Player {
        public string name {get; set;}
        public int HP { get; set; }

        public List<Card> hand = new List<Card>();

        public Card draw(Deck deck){
            Card drawCard = deck.Deal();
            hand.Add(drawCard);
            return drawCard;
        }

        public Card discard(int index){
            if(index > hand.Count-1) return null;
            Card card = hand[index];
            hand.Remove(card);
            return card;
        }



        public Player(string val){
            this.name = val;
            this.HP = 200;
        }

        public void listCard(){
            foreach (var card in hand)
            {
                // System.Console.WriteLine($"Card: {card.suit} {card.stringVal}");
                Console.ForegroundColor = card.Color;
                System.Console.Write($"{name}'s cards:");
                System.Console.Write($" {card.suit} {card.stringVal}");
                System.Console.WriteLine();

                Console.ResetColor();
            }
        }

        public void ListCard(int NumPerRow)
        {
            if(this.hand.Count == 0) return;

            int Counter = this.hand.Count();
            int Row = 0;
            while(Counter >= NumPerRow * (Row + 1)){
                int StartIndex = Row * NumPerRow;
                int EndIndex = NumPerRow * (Row + 1);

                if(EndIndex >= this.hand.Count()) {
                    EndIndex = this.hand.Count() - 1;
                    // System.Console.WriteLine(EndIndex);
                }

                // List<Card> rowCards = this.Cards.GetRange(0, 13);
                IEnumerable<Card> rowCards = this.hand.Skip(StartIndex).Take(13).Select(c =>c);
 
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