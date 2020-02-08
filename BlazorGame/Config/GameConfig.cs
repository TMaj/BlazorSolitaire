namespace BlazorGame.Config
{
    public class GameConfig
    {
        public const int StockpileDeckNumber = 0;
    
        public const int TalonpileDeckNumber = 1;

        public readonly int[] TableauDeckNumbers = new int [7] { 2, 3, 4, 5, 6, 7, 8 };

        public readonly int[] FoundationsDeckNumbers = new int [4] { 9, 10, 11, 12 };
    }
}
