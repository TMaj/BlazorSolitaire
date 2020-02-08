using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers.PickingCardsValidators
{
    public class StockpilePickingCardsValidator : TableauCardsValidatorBase, IPickingCardsValidator
    {
        public bool Validate(IList<CardModel> cardsInDeck, CardModel pickedCard)
        {
            return false;
        }
    }
}
