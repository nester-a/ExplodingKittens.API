namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IPlayer : IHand
    {
        void GetCardFromDeck(IDeck deck);
    }
}
