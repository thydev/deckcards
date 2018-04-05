using System.Collections.Generic;
using System;

public class Deck {
    private static Random _rand;

    public List<Card> cards = new List<Card>();
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
                cards.Add(card);
            }
        }
    }

    public Card deal(){
        Card dealCard;
        dealCard = cards[cards.Count-1];
        cards.RemoveAt(cards.Count-1);
        return  dealCard;
    }

    public void reset(){
        cards.Clear();
        foreach (var suit in suits)
        {
            for (int i = 1; i <= 13; i++)
            {
                
                Card card = new Card();
                card.stringVal = (i == 1) ? "Ace": (i == 11) ? "Jack" : (i == 12) ? "Queen" : (i == 13) ? "King" : $"{i}";
                card.suit = suit;
                card.val = i;
                cards.Add(card);
            }
        }
    }

    public void shuffle(int num){
        _rand = new Random();
        for (int i = 0; i < num; i++)
        {
            int idx1 = _rand.Next(0, cards.Count);
            int idx2 = _rand.Next(0, cards.Count);
            Card tmp = new Card();
            tmp = cards[idx1];
            cards[idx1] = cards[idx2];
            cards[idx2] = tmp;
        }
    }

    public void listCard(){
        foreach (var card in cards)
        {
            // System.Console.WriteLine($"Card: {card.suit} {card.stringVal}");
            switch(card.suit)
            {
                case "♥":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "♦":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "♣":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "♠":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }

            System.Console.Write("Card:");
            System.Console.Write($" {card.suit} {card.stringVal}");
            System.Console.WriteLine();
            
            Console.ResetColor();
            // Console.ForegroundColor = ConsoleColor.Green;
            // System.Console.Write("Card:");

        }
    }
}