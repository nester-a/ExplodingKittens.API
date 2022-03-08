namespace ExplodingKittens.API.Base.Interfaces
{
    public interface IDeck
    {
        Stack<ICard> ThisDeck { get; }
    }
}
