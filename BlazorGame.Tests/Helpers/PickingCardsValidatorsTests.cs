using BlazorGame.Helpers;
using BlazorGame.Models;
using BlazorGame.Tests.Helpers.TheoryData.PickingCardsValidatorTheoryData;
using System.Collections.Generic;
using Xunit;

namespace BlazorGame.Tests.Helpers
{
    public  class PickingCardsValidatorsTests
    {
        [Theory]
        [ClassData(typeof(TableauPickingCardsValidatorTheoryData))]
        [ClassData(typeof(TalonpilePickingCardsValidatorTheoryData))]
        [ClassData(typeof(FoundationsPickingCardsValidatorTheoryData))]
        [ClassData(typeof(StockpilePickingCardsValidatorTheoryData))]
        public void Validate_Should_ReturnCorrectValueBasedOnProvidedCards(
            IPickingCardsValidator validator,
            IList<CardModel> cards,
            CardModel pickedCard,
            bool validationResult)
        {
            Assert.Equal(validator.Validate(cards, pickedCard), validationResult);
        }
    }
}