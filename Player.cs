using System;
using System.Collections.Generic;
public class Player {
    public string name;

    public List<Card> hand = new List<Card>();

    public Card draw(Deck deck){
        Card drawCard = deck.deal();
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
            System.Console.WriteLine($"{name}'s card: {card.suit} {card.stringVal}");
        }
    }
}