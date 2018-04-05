using System;

namespace deckcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Player player1 = new Player("Toto");
            Player player2 = new Player("Thy");

            System.Console.WriteLine(d1.cards[0].stringVal + d1.cards[0].suit);
            d1.listCard();
            System.Console.WriteLine("Shuffling....");
            d1.shuffle(100);
            d1.listCard();

            // System.Console.WriteLine( d1.deal().stringVal );
            // System.Console.WriteLine( d1.deal().stringVal);
            // System.Console.WriteLine( d1.deal().stringVal);

            player1.draw(d1);
            player2.draw(d1);
            player1.draw(d1);
            player2.draw(d1);

            System.Console.WriteLine(d1.cards.Count);
            player1.listCard();
            player2.listCard();

            System.Console.WriteLine(player1.discard(0));
            System.Console.WriteLine(player2.discard(1));
            System.Console.WriteLine(player1.discard(1));//null
            System.Console.WriteLine(player2.discard(1)); //null


            d1.reset();

        }
    }
}
