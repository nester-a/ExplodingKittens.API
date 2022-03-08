using ExplodingKittens.API.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
