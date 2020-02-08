namespace BlazorGame.Helpers
{
    public interface IValidator<T1, T2>
    {
        bool Validate(T1 cardsInDeck, T2 pickedCard);
    }
}
