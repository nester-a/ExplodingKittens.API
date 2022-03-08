using Xunit;
using ExplodingKittens.API.Base.Classes;

namespace ExplodingKittens.API.Tests.ClassesTests
{
    public class PlayersTests
    {

        [Fact]
        public void GetCardFromDeckTest()
        {
            Player one = new Player();
            Player two = new Player();
            Deck deck = new Deck(new Card("Hello"), new Card("World"));

            one.GetCardFromDeck(deck);
            two.GetCardFromDeck(deck);

            Assert.True(one.Hand.Count == 1 && two.Hand.Count == 1 && deck.ThisDeck.Count == 0);
        }
    }
}
