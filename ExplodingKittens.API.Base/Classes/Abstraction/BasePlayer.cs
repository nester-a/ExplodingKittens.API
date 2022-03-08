using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes.Abstraction
{
    internal abstract class BasePlayer : IPlayer
    {
        public IHand Hand { get; private set; }

        public IPlayerAction DoTurn(ICard cardForTurn, IDeck deck, IPlayer nextPlayer)
        {
            if(cardForTurn.Effect != null)
                GetFromDeck(deck);
            return EndTurn(nextPlayer);
        }

        public IPlayerAction EndTurn(IPlayer nextPlayer)
        {
            throw new NotImplementedException();
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
