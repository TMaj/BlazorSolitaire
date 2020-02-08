using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Builder.Interfaces
{
    public interface IDeckBuilderContext
    {
        IDeckBuilderContext WithColor(Colors color);

        IDeckBuilderContext WithSuit(Suits suit);

        IDeckBuilderContext Shuffled();

        List<CardModel> Build();
    }
}
