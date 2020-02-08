using BlazorGame.Builder.Interfaces;
using BlazorGame.Extensions;
using BlazorGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Builder
{
    public class DeckBuilder
    {

        public static IDeckBuilderContext CreateDeck()
        {
            return new DeckBuilderContext();
        }

        public class DeckBuilderContext : IDeckBuilderContext
        {
            private HashSet<Suits> suits = new HashSet<Suits>();
            private HashSet<Colors> colors = new HashSet<Colors>();
            private bool shuffle;

            public IDeckBuilderContext WithColor(Colors color)
            {
                switch (color)
                {
                    case Colors.Black:
                        {
                            this.suits.Add(Suits.Clubs);
                            this.suits.Add(Suits.Spades);
                            return this;
                        }
                    case Colors.Red:
                        {
                            this.suits.Add(Suits.Diamonds);
                            this.suits.Add(Suits.Hearts);
                            return this;
                        }
                }

                return this;
            }

            public IDeckBuilderContext WithSuit(Suits suit)
            {
                this.suits.Add(suit);
                return this;
            }

            public IDeckBuilderContext Shuffled()
            {
                this.shuffle = true;
                return this;
            }

            public List<CardModel> Build()
            {
                var cards = this.suits.SelectMany(suit =>
                    (Enum.GetValues(typeof(Ranks)) as Ranks[]).Select(rank => new CardModel { Rank = rank, Suit = suit }));

                return (this.shuffle ? this.Shuffle(cards.ToList()) : cards).ToList();
            }

            private IList<CardModel> Shuffle(IList<CardModel> cards)
            {
                for (var i = 0; i < 15; ++i)
                {
                    cards = cards.Shuffle();
                }

                return cards;
            }
        }
    }

    
}
