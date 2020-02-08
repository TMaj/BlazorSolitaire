using BlazorGame.Helpers;
using BlazorGame.Helpers.DroppingCardsValidators;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.Base;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Tests.Helpers.TheoryData.DroppingCardsValidatorTheoryData
{
    internal class TableauDroppingCardsValidatorTheoryData : CardsValidatorTheoryDataBase<IDroppingCardsValidator>
    {
        public TableauDroppingCardsValidatorTheoryData() 
            : base(new TableauDroppingCardsValidator())
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
                new List<object> { cards.Skip(3).Take(1).ToList(), cards.Take(3).ToList(), true },
                new List<object> { cards.Skip(2).Take(2).ToList(), cards.Take(2).ToList(), true },
                new List<object> { cards.Skip(1).Take(3).ToList(), cards.Take(1).ToList(), false },
            };
        }
    }
}