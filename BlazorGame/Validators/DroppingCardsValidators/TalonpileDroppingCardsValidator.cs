using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers.DroppingCardsValidators
{
    public class TalonpileDroppingCardsValidator : TableauCardsValidatorBase, IDroppingCardsValidator
    {
        public bool Validate(IList<CardModel> draggedCards, IList<CardModel> deckCards)
        {
            return false;
        }
    }
}
