using BlazorGame.Helpers;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.DroppingCardsValidatorTheoryData;
using System.Collections.Generic;
using Xunit;

namespace BlazorGame.Tests.Helpers
{
    public class DroppingCardsValidatorsTests
    {
        [Theory]
        [ClassData(typeof(TableauDroppingCardsValidatorTheoryData))]
        [ClassData(typeof(FoundationsDroppingCardsValidatorTheoryData))]
        [ClassData(typeof(StockpileDroppingCardsValidatorTheoryData))]
        [ClassData(typeof(TalonpileDroppingCardsValidatorTheoryData))]
        public void Validate_Should_ReturnCorrectValueBasedOnProvidedCards(
            IDroppingCardsValidator validator,
            IList<CardModel> draggedCards,
            IList<CardModel> deckCards,
            bool validationResult)
        {
            Assert.Equal(validator.Validate(draggedCards, deckCards), validationResult);
        }
    }
}