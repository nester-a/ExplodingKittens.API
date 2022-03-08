namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IDeck
    {
        Stack<ICard> ThisDeck { get; }
    }
}
