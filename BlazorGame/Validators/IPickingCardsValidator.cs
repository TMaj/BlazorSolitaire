using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers
{
    public interface IPickingCardsValidator : IValidator<IList<CardModel>, CardModel>
    {
    }
}