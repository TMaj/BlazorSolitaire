using BlazorGame.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Extensions
{
    public static class DeckExtensions
    {
        /// <summary>
        /// Returns a list of cards from stack above a picked one.
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="pickedCard"></param>
        /// <returns></returns>
        public static List<CardModel> GetPickedCards(this List<CardModel> cards, CardModel pickedCard)
        {
            var pickedCardIndex = cards.IndexOf(pickedCard);

            return cards
                .Skip(pickedCardIndex)
                .Take(cards.Count - pickedCardIndex)
                .ToList();
        }

        /// <summary>
        /// Distributes cards among tableau stacks.
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="decksNumber"></param>
        public static List<CardModel> DistributeCards(this List<CardModel> cards, int decksNumber)
        {
            var stack = new Stack<CardModel>(cards.Take(CalculateCardsAmount(decksNumber)));

            for (var i = 0; i < decksNumber; ++i)
            {
                var group = new List<CardModel>();

                for (var j = 0; j < i + 1; ++j)
                {
                    group.Add(stack.Pop());
                }

                var cardPosition = 0;
                foreach (var card in group)
                {
                    card.DeckNumber = i + 2;
                    card.PositionInDeck = cardPosition++;
                    card.Visible = false;
                }

                group.Last().Visible = true;
            }

            return cards;
        }

        /// <summary>
        /// Calculates how many cards are required to create tableau stacks.
        /// </summary>
        /// <param name="decksNumber">Amount of tableau stacks.</param>
        /// <returns></returns>
        private static int CalculateCardsAmount(int decksNumber)
        {
            var cardsNumber = 0;

            for (var i = 0; i < decksNumber; ++i)
            {
                cardsNumber += cardsNumber + i + 1;
            }

            return cardsNumber;
        }
    }
}
