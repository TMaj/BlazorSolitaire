using BlazorGame.Helpers;
using BlazorGame.Helpers.DroppingCardsValidators;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.Base;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Tests.Helpers.TheoryData.DroppingCardsValidatorTheoryData
{
    internal class FoundationsDroppingCardsValidatorTheoryData : CardsValidatorTheoryDataBase<IDroppingCardsValidator>
    {
        public FoundationsDroppingCardsValidatorTheoryData()
            : base(new FoundationsDroppingCardsValidator())
        {
        }

        protected override IList<List<object>> GetTheoryData()
        {
            var cards = new List<CardModel>
            {
                new CardModel
                {
                    Rank = Ranks.Ace,
                    Suit = Suits.Clubs,
                },
                new CardModel
                {
                    Rank = Ranks.Two,
                    Suit = Suits.Clubs,
                },
                new CardModel
                {
                    Rank = Ranks.Two,
                    Suit = Suits.Hearts,
                },
                new CardModel
                {
                    Rank = Ranks.Ten,
                    Suit = Suits.Hearts,
                },
                new CardModel
                {
                    Rank = Ranks.Nine,
                    Suit = Suits.Clubs,
                },
                new CardModel
                {
                    Rank = Ranks.Eight,
                    Suit = Suits.Diamonds,
                },
            };

            return new List<List<object>>
            {
                new List<object> { cards.Take(1).ToList(), new List<CardModel>(), true },
                new List<object> { cards.Skip(1).Take(1).ToList(), cards.Take(1).ToList(), true },
                new List<object> { cards.Skip(3).Take(3).ToList(), new List<CardModel>(), false },
                new List<object> { cards.Skip(3).Take(3).ToList(), cards.Take(1).ToList(), false },
                new List<object> { cards.Skip(1).Take(3).ToList(), cards.Take(1).ToList(), false },
            };
        }
    }
}