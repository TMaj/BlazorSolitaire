using BlazorGame.Builder;
using BlazorGame.Models;
using System;
using System.Linq;
using Xunit;

namespace BlazorGame.Tests.Builder
{
    public class DeckBuilderTests
    {
        [Fact]
        public void BuildWithColor_Should_ReturnAllCards_When_GivenRedAndBlackColors()
        {
            var blackCards = DeckBuilder
                .CreateDeck()
                .WithColor(Colors.Black)
                .Build();

            var redCards = DeckBuilder
                .CreateDeck()
                .WithColor(Colors.Red)
                .Build();

            var ranks = (Enum.GetValues(typeof(Ranks)) as Ranks[]).ToList();

            Assert.Equal(ranks.Count * 2, blackCards.Count());
            Assert.Equal(ranks.Count * 2, redCards.Count());

            ranks.ForEach(rank => Assert.Contains(blackCards, card => card.Rank == rank && card.Suit == Suits.Clubs));
            ranks.ForEach(rank => Assert.Contains(blackCards, card => card.Rank == rank && card.Suit == Suits.Spades)); 
            ranks.ForEach(rank => Assert.Contains(redCards, card => card.Rank == rank && card.Suit == Suits.Hearts));
            ranks.ForEach(rank => Assert.Contains(redCards, card => card.Rank == rank && card.Suit == Suits.Diamonds));
        }

        [Fact]
        public void BuildWithSuit_Should_ReturnAllCardsOfGivenSuit()
        {
            var suits = (Enum.GetValues(typeof(Suits)) as Suits[]).ToList();
            var ranks = (Enum.GetValues(typeof(Ranks)) as Ranks[]).ToList();

            suits.ForEach(suit =>
            {
                var cards = DeckBuilder.CreateDeck().WithSuit(suit).Build();
                Assert.Equal(ranks.Count, cards.Count());
                ranks.ForEach(rank => Assert.Contains(cards, card => card.Rank == rank && card.Suit == suit));
            });
        }

        [Fact]
        public void BuildWithShuffle_Should_ReturnCardsShuffled()
        {
            var cards = DeckBuilder
                .CreateDeck()
                .WithSuit(Suits.Clubs)
                .Shuffled()
                .Build()
                .ToList();

            var ranks = (Enum.GetValues(typeof(Ranks)) as Ranks[]).ToList();

            var shuffled = false;
            for (var i = 0; i < ranks.Count; ++i)
            {
                if (cards[i].Rank != ranks[i])
                {
                    shuffled = true;
                }
            }

            Assert.True(shuffled);
        }

        [Fact]
        public void BuildWithoutShuffle_Should_ReturnCardsNotShuffled()
        {
            var cards = DeckBuilder
               .CreateDeck()
               .WithSuit(Suits.Clubs)
               .Build()
               .ToList();

            var ranks = (Enum.GetValues(typeof(Ranks)) as Ranks[]).ToList();

            var shuffled = false;
            for (var i = 0; i < ranks.Count; ++i)
            {
                if (cards[i].Rank != ranks[i])
                {
                    shuffled = true;
                }
            }

            Assert.False(shuffled);
        }
    }
}
