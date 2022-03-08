namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IPlayer : IGetCard, IDoTurn
    {
        IHand Hand { get; }
    }
}
