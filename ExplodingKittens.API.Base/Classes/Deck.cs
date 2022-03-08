using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes
{
    public class Deck : IDeck
    {
        public Stack<ICard> ThisDeck {get; private set;}
        public Deck(params ICard[] cards)
        {
            ThisDeck = new Stack<ICard>();
            foreach (var card in cards)
            {
                ThisDeck.Push(card);
            }
        }
    }
}
