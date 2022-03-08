namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IGetCard : IPlayerAction
    {
        void GetFromDeck(IDeck deck);
        void GetFromHand(IHand playerHand, ICard card);
    }
}
