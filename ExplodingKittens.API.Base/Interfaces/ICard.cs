namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface ICard : IName
    {
        IEffect Effect { get; }
    }
}
