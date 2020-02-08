using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers.PickingCardsValidators
{
    public class TalonpilePickingCardsValidator : TableauCardsValidatorBase, IPickingCardsValidator
    {
        public bool Validate(IList<CardModel> cardsInDeck, CardModel pickedCard)
        {
            return cardsInDeck.Count - 1 == pickedCard.PositionInDeck;
        }
    }
}
