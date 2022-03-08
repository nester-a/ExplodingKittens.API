namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IDoTurn
    {
        IEffect DoTurn(ICard cardForTurn, IDeck deck);
    }
}
