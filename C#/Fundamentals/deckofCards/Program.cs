using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck NewDeck = new Deck();
            Player player1 = new Player();
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.reset());
            Console.WriteLine(NewDeck.Cards.Count);
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(NewDeck.shuffle2());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(NewDeck.shuffle());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(NewDeck.top_most());
            Console.WriteLine(player1.Draw());
            Console.WriteLine(player1.Draw());
            Console.WriteLine(player1.Discard(1));
        }
    }
}