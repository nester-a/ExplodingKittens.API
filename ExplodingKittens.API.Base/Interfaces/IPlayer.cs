namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IPlayer : IGetCard, IDoTurn, IEndTurn
    {
        IHand Hand { get; }
    }
}
