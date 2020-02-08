using BlazorGame.Helpers;
using BlazorGame.Helpers.PickingCardsValidators;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.Base;
using System.Collections.Generic;

namespace BlazorGame.Tests.Helpers.TheoryData.PickingCardsValidatorTheoryData
{
    internal class FoundationsPickingCardsValidatorTheoryData : CardsValidatorTheoryDataBase<IPickingCardsValidator>
    {
        public FoundationsPickingCardsValidatorTheoryData() 
            : base(new FoundationsPickingCardsValidator())
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
                    PositionInDeck = 0,
                },
                new CardModel
                {
                    Rank = Ranks.Ten,
                    Suit = Suits.Hearts,
                    PositionInDeck = 1,
                },
                new CardModel
                {
                    Rank = Ranks.Nine,
                    Suit = Suits.Clubs,
                    PositionInDeck = 2,
                },
                new CardModel
                {
                    Rank = Ranks.Eight,
                    Suit = Suits.Diamonds,
                    PositionInDeck = 3,
                },
            };

            return new List<List<object>>
            {
                new List<object> { cards, cards[3], true },
                new List<object> { cards, cards[1], false },
                new List<object> { cards, cards[2], false },
                new List<object> { cards, cards[0], false },
            };
        }
    }
}