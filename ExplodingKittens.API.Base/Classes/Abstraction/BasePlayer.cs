using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes.Abstraction
{
    internal abstract class BasePlayer : IPlayer
    {
        public IHand Hand { get; private set; }

        public IEffect DoTurn(ICard cardForTurn, IDeck deck)
        {
            GetFromDeck(deck);
        }

        public void GetFromDeck(IDeck deck)
        {
            Hand.Cards.Add(deck.Deck.Pop());
        }

        public void GetFromHand(IHand playerHand, ICard card)
        {
            ICard newCard = playerHand.Cards.FirstOrDefault(card);
            Hand.Cards.Add(newCard);
        }
    }
}
