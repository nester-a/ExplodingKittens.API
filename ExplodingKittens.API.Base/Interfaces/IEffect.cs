namespace ExplodingKittens.API.Base.Interfaces
{
    internal interface IEffect
    {
        string Description { get; }
        void GetEffect();
    }
}
