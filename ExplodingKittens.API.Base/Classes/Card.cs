using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes
{
    internal class Card : ICard
    {
        public string Description {get; private set;}
        public Card(string description)
        {
            Description = description;
        }
    }
}
