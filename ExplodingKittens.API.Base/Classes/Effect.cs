using ExplodingKittens.API.Base.Interfaces;

namespace ExplodingKittens.API.Base.Classes
{
    internal class Effect : IEffect
    {
        public string Description {get; private set;}

        public void GetEffect()
        {
            throw new NotImplementedException();
        }
        public Effect(string description)
        {
            Description = description;
        }
    }
}
