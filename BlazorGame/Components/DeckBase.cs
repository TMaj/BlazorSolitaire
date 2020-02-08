using BlazorGame.Components.Events;
using BlazorGame.Extensions;
using BlazorGame.Helpers;
using BlazorGame.Models;
using BlazorGame.Pages;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGame.Components
{
    public class DeckBase : ComponentBase
    {
        [CascadingParameter]public GameContainer Container { get; set; }
        [Parameter] public int DeckNumber { get; set; }
        [Parameter] public IPickingCardsValidator PickingCardsValidator { get; set; }
        [Parameter] public IDroppingCardsValidator DroppingCardsValidator { get; set; }

        protected List<CardModel> cards = new List<CardModel>();

        protected override void OnParametersSet()
        {
            this.cards.Clear();

            if (!this.Container.Cards.Any(c => c.DeckNumber == this.DeckNumber))
            {
                return;
            }

            this.cards.AddRange(Container.Cards
                .Where(card => card.DeckNumber == this.DeckNumber)
                .OrderBy(card => card.PositionInDeck));

            this.cards.Last().Visible = true;
        }

        public void OnDragStart(CardModel card)
        {
            this.Container.PickedCards = this.cards.GetPickedCards(card);
        }

        public async Task HandleDrop()
        {
            if (!this.DroppingCardsValidator.Validate(this.Container.PickedCards, this.cards))
            {
                return;
            }
            
            await this.Container.OnCardsChangedAsync(new CardsChangedArgs(true, this.DeckNumber, this.cards.Count()));
        }
    }
}
