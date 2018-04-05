using System;
namespace deckcards {
    public class Card {
        //Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King
        public string stringVal {get; set;}
        // suits: clubs (♣), diamonds (♦), hearts (♥) and spades (♠),
        private static Random _rand;
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

        public int Damage { 
            get {
                _rand = new Random();
                if(this.val >= 2 && this.val <= 5) {
                    return _rand.Next(10, 21);
                } else if (this.val >= 6 && this.val <= 10){
                    return _rand.Next(20, 41);
                } else if (this.val == 1 || (this.val >= 11 && this.val <= 13)){
                    return _rand.Next(40, 61);
                }
                        
                return 0;       
            } 
        }

        public int EnergyCost {
            get {
                if(this.val >= 2 && this.val <= 5) {
                    return 1;
                } else if (this.val >= 6 && this.val <= 10){
                    return 2;
                } else if (this.val == 1 || (this.val >= 11 && this.val <= 13)){
                    return 3;
                }
                        
                return 0;       
            } 
        }
    }
}