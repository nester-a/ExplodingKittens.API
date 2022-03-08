namespace ExplodingKittens.API.Base.Interfaces
{
    public interface IPlayer : IHand
    {
        void GetCardFromDeck(IDeck deck);
    }
}
