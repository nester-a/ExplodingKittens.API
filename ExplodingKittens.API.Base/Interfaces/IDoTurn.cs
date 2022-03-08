namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IDoTurn : IPlayerAction
    {
        IPlayerAction DoTurn(ICard cardForTurn, IDeck deck, IPlayer nextPlayer);
    }
}
