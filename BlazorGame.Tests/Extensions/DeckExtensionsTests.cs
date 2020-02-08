using BlazorGame.Builder;
using BlazorGame.Extensions;
using BlazorGame.Models;
using System.Linq;
using Xunit;

namespace BlazorGame.Tests.Extensions
{
    public class DeckExtensionsTests
    {
        [Fact]
        public void DistributeCards_Should_AssignProperDecksNumberForCards()
        {
            var cards = DeckBuilder
                .CreateDeck()
                .WithColor(Colors.Black)
                .WithColor(Colors.Red)
                .Shuffled()
                .Build()
                .Take(28)
                .ToList()
                .DistributeCards(7);

            for (var i = 0; i < 7; ++i)
            {
                Assert.Equal(i + 1, cards.Where(card => card.DeckNumber == i + 2).Count());
            }
        }
    }
}
