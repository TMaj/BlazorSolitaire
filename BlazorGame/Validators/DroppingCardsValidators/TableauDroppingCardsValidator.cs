using BlazorGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Helpers.DroppingCardsValidators
{
    public class TableauDroppingCardsValidator : TableauCardsValidatorBase, IDroppingCardsValidator
    {
        public bool Validate(IList<CardModel> draggedCards, IList<CardModel> deckCards)
        {
            return this.ValidateDescendant(deckCards.LastOrDefault(), draggedCards.First());
        }
    }
}