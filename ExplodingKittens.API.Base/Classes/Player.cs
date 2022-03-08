using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes
{
    public class Player : IPlayer
    {
        public List<ICard> Hand { get; private set; }

        public void GetCardFromDeck(IDeck deck)
        {
            Hand.Add(deck.ThisDeck.Pop());
        }

        public Player()
        {
            Hand = new List<ICard>();
        }
    }
}
