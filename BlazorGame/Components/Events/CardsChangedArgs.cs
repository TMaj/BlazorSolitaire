namespace BlazorGame.Components.Events
{
    public class CardsChangedArgs
    {
        public CardsChangedArgs(bool cardsDropped)
        {
            this.CardsDropped = cardsDropped;
        }

        public CardsChangedArgs(bool cardsDropped, int newDeckNumber, int positionInNewDeck)
            : this(cardsDropped)
        {
            this.NewDeckNumber = newDeckNumber;
            this.PositionInNewDeck = positionInNewDeck;
        }

        public bool CardsDropped { get; set; }

        public int NewDeckNumber { get; set; }

        public int PositionInNewDeck { get; set; }
    }
}
