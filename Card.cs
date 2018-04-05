using System;
namespace deckcards {
    public class Card {
        //Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King
        public string stringVal {get; set;}
        // suits: clubs (♣), diamonds (♦), hearts (♥) and spades (♠),
        public string suit {get; set;}
        public int val {get; set;}
        public ConsoleColor Color { 
            get {
                switch(this.suit)
                {
                    case "♥":
                        return Setting.HeartsColor;
                    case "♦":
                        return Setting.DiamondsColor;
                    case "♣":
                        return Setting.ClubsColor;
                    case "♠":
                        return Setting.SpadesColor;
                }
                return ConsoleColor.Green;
            } 
        }
    }
}