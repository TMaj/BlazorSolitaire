using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers
{
    public interface IDroppingCardsValidator : IValidator<IList<CardModel>, IList<CardModel>>
    {
    }
}