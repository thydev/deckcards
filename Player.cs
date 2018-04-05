using System;
using System.Collections.Generic;

namespace deckcards {
    public class Player {
        public string name {get; set;}

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
            name = val;
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
    }
}