namespace BlazorGame.Models
{
    public class CardModel
    {
        public Ranks Rank { get; set; }

        public Suits Suit { get; set; }

        public Colors Color => Suit == Suits.Clubs || Suit == Suits.Spades ? Colors.Black : Colors.Red;

        public int DeckNumber { get; set; }

        public int PositionInDeck { get; set; }

        public bool Visible { get; set; } = true;

        public override string ToString()
        {
            return $"{this.Rank.ToString()} {this.Suit.ToString()} {this.Color.ToString()}";
        }
    }
}