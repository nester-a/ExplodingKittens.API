using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes
{
    public class Card : ICard
    {
        public string Description {get; private set;}
        public Card(string description)
        {
            Description = description;
        }
    }
}
