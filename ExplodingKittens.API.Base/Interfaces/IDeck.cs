namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IDeck
    {
        Stack<ICard> Deck { get; }
    }
}
