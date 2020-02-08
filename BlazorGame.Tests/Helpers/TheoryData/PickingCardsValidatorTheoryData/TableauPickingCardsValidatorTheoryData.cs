using BlazorGame.Helpers;
using BlazorGame.Helpers.PickingCardsValidators;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.Base;
using System.Collections.Generic;

namespace BlazorGame.Tests.Helpers.TheoryData.PickingCardsValidatorTheoryData
{
    internal class TableauPickingCardsValidatorTheoryData : CardsValidatorTheoryDataBase<IPickingCardsValidator>
    {
        public TableauPickingCardsValidatorTheoryData() 
            : base(new TableauPickingCardsValidator())
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
                new List<object> { cards, cards[3], true },
                new List<object> { cards, cards[1], true },
                new List<object> { cards, cards[2], true },
                new List<object> { cards, cards[0], false },
            };
        }
    }
}
