using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers.PickingCardsValidators
{
    public class TableauPickingCardsValidator : TableauCardsValidatorBase, IPickingCardsValidator
    {
        public bool Validate(IList<CardModel> cards, CardModel card)
        {
            for (var i = cards.IndexOf(card); i < cards.Count; ++i)
            {
                /// No descendants of chosen card.
                if (i + 1 > cards.Count - 1)
                {
                    return true;
                }

                if (!this.ValidateDescendant(cards[i], cards[i + 1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
