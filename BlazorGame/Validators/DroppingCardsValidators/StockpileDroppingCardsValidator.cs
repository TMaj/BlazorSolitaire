using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers.DroppingCardsValidators
{
    public class StockpileDroppingCardsValidator : TableauCardsValidatorBase, IDroppingCardsValidator
    {
        public bool Validate(IList<CardModel> draggedCards, IList<CardModel> deckCards)
        {
            return false;
        }
    }
}
