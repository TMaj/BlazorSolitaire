using BlazorGame.Models;
using System.Collections.Generic;

namespace BlazorGame.Helpers
{
    public class ImageHelper
    {
        private static Dictionary<Suits, Dictionary<Ranks, string>> cardsByImages = new Dictionary<Suits, Dictionary<Ranks, string>>
        {
            [Suits.Clubs] = new Dictionary<Ranks, string>
            {
                [Ranks.Ace] = "./img/AC.png",
                [Ranks.Two] = "./img/2C.png",
                [Ranks.Three] = "./img/3C.png",
                [Ranks.Four] = "./img/4C.png",
                [Ranks.Five] = "./img/5C.png",
                [Ranks.Six] = "./img/6C.png",
                [Ranks.Seven] = "./img/7C.png",
                [Ranks.Eight] = "./img/8C.png",
                [Ranks.Nine] = "./img/9C.png",
                [Ranks.Ten] = "./img/10C.png",
                [Ranks.Jack] = "./img/JC.png",
                [Ranks.Queen] = "./img/QC.png",
                [Ranks.King] = "./img/KC.png",
            },
            [Suits.Diamonds] = new Dictionary<Ranks, string>
            {
                [Ranks.Ace] = "./img/AD.png",
                [Ranks.Two] = "./img/2D.png",
                [Ranks.Three] = "./img/3D.png",
                [Ranks.Four] = "./img/4D.png",
                [Ranks.Five] = "./img/5D.png",
                [Ranks.Six] = "./img/6D.png",
                [Ranks.Seven] = "./img/7D.png",
                [Ranks.Eight] = "./img/8D.png",
                [Ranks.Nine] = "./img/9D.png",
                [Ranks.Ten] = "./img/10D.png",
                [Ranks.Jack] = "./img/JD.png",
                [Ranks.Queen] = "./img/QD.png",
                [Ranks.King] = "./img/KD.png",
            },
            [Suits.Hearts] = new Dictionary<Ranks, string>
            {
                [Ranks.Ace] = "./img/AH.png",
                [Ranks.Two] = "./img/2H.png",
                [Ranks.Three] = "./img/3H.png",
                [Ranks.Four] = "./img/4H.png",
                [Ranks.Five] = "./img/5H.png",
                [Ranks.Six] = "./img/6H.png",
                [Ranks.Seven] = "./img/7H.png",
                [Ranks.Eight] = "./img/8H.png",
                [Ranks.Nine] = "./img/9H.png",
                [Ranks.Ten] = "./img/10H.png",
                [Ranks.Jack] = "./img/JH.png",
                [Ranks.Queen] = "./img/QH.png",
                [Ranks.King] = "./img/KH.png",
            },
            [Suits.Spades] = new Dictionary<Ranks, string>
            {
                [Ranks.Ace] = "./img/AS.png",
                [Ranks.Two] = "./img/2S.png",
                [Ranks.Three] = "./img/3S.png",
                [Ranks.Four] = "./img/4S.png",
                [Ranks.Five] = "./img/5S.png",
                [Ranks.Six] = "./img/6S.png",
                [Ranks.Seven] = "./img/7S.png",
                [Ranks.Eight] = "./img/8S.png",
                [Ranks.Nine] = "./img/9S.png",
                [Ranks.Ten] = "./img/10S.png",
                [Ranks.Jack] = "./img/JS.png",
                [Ranks.Queen] = "./img/QS.png",
                [Ranks.King] = "./img/KS.png",
            }
        };

        private static string cardReverse = "./img/card_back.png";

        public static string GetCardImage(bool visible, Suits suit, Ranks rank) => visible ?  cardsByImages[suit][rank] : cardReverse;
    }
}