using BlazorGame.Extensions;
using BlazorGame.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Helpers.DroppingCardsValidators
{
    public class FoundationsDroppingCardsValidator : IDroppingCardsValidator
    {
        public bool Validate(IList<CardModel> draggedCards, IList<CardModel> deckCards)
        {
            if (draggedCards.Count > 1)
            {
                return false;
            } 

            if (deckCards.IsNullOrEmpty() && draggedCards.First().Rank == Ranks.Ace)
            {
                return true;
            }

            return ValidateDescendant(deckCards.OrderBy(card => card.PositionInDeck)?.Last(), draggedCards.First());
        }

        private bool ValidateDescendant(CardModel ascendant, CardModel descendant)
        {
            var descendantRankAndColor = this.GetDescendantRequiredRankAndColor(ascendant);
            return descendantRankAndColor.HasValue &&
                descendant.Color == descendantRankAndColor.Value.Color &&
                descendant.Rank == descendantRankAndColor.Value.Rank;
        }

        private (Ranks Rank, Colors Color)? GetDescendantRequiredRankAndColor(CardModel card)
        {
            var requiredColor = card.Color;

            switch (card.Rank)
            {
                case Ranks.Ace:
                    return (Ranks.Two, requiredColor);
                case Ranks.Two:
                    return (Ranks.Three, requiredColor);
                case Ranks.Three:
                    return (Ranks.Four, requiredColor);
                case Ranks.Four:
                    return (Ranks.Five, requiredColor);
                case Ranks.Five:
                    return (Ranks.Six, requiredColor);
                case Ranks.Six:
                    return (Ranks.Seven, requiredColor);
                case Ranks.Seven:
                    return (Ranks.Eight, requiredColor);
                case Ranks.Eight:
                    return (Ranks.Nine, requiredColor);
                case Ranks.Nine:
                    return (Ranks.Ten, requiredColor);
                case Ranks.Ten:
                    return (Ranks.Jack, requiredColor);
                case Ranks.Jack:
                    return (Ranks.Queen, requiredColor);
                case Ranks.Queen:
                    return (Ranks.King, requiredColor);
                default:
                    return null;
            }
        }
    }
}
