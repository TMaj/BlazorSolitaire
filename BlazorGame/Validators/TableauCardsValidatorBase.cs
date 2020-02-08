using BlazorGame.Models;

namespace BlazorGame.Helpers
{
    public abstract class TableauCardsValidatorBase
    {
        protected bool ValidateDescendant(CardModel ascendant, CardModel descendant)
        {
            if (ascendant == null && descendant.Rank == Ranks.King)
            {
                return true;
            }

            var descendantRankAndColor = this.GetDescendantRequiredRankAndColor(ascendant);
            return descendantRankAndColor.HasValue &&
                descendant.Color == descendantRankAndColor.Value.Color &&
                descendant.Rank == descendantRankAndColor.Value.Rank;
        }

        private (Ranks Rank, Colors Color)? GetDescendantRequiredRankAndColor(CardModel card)
        {
            var requiredColor = card.Color == Colors.Red ? Colors.Black : Colors.Red;

            switch (card.Rank)
            {
                case Ranks.Two:
                    return (Ranks.Ace, requiredColor);
                case Ranks.Three:
                    return (Ranks.Two, requiredColor);
                case Ranks.Four:
                    return (Ranks.Three, requiredColor);
                case Ranks.Five:
                    return (Ranks.Four, requiredColor);
                case Ranks.Six:
                    return (Ranks.Five, requiredColor);
                case Ranks.Seven:
                    return (Ranks.Six, requiredColor);
                case Ranks.Eight:
                    return (Ranks.Seven, requiredColor);
                case Ranks.Nine:
                    return (Ranks.Eight, requiredColor);
                case Ranks.Ten:
                    return (Ranks.Nine, requiredColor);
                case Ranks.Jack:
                    return (Ranks.Ten, requiredColor);
                case Ranks.Queen:
                    return (Ranks.Jack, requiredColor);
                case Ranks.King:
                    return (Ranks.Queen, requiredColor);
                default:
                    return null;
            }
        }
    }
}
