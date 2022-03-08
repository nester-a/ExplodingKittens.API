using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes.Abstraction
{
    internal abstract class Card : ICard
    {
        public string Name {get; private set;}

        public IEffect Effect {get; private set;}

        public Card(string name, IEffect effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
