namespace NewBlackjackProject
{
    public class Card
    {
        public Card(CardFace cardFace, Suit suit)
        {
            CardFace = cardFace;
            Suit = suit;
        }

        public CardFace CardFace { get; }
        public Suit Suit { get; }

        public string FormatCardString()
        {
            var newString = ($"[{CardFace.ToString()}, {Suit.ToString()}]");
            return newString;
        }
        
        public int GetValue(int currentTotal)
        {
            int value = 0;

            if (CardFace == CardFace.Ace && currentTotal <= 10)
            {
                value = 11;
            }
            
            else if (CardFace == CardFace.Ace)
            {
                value = 1;
            }
            
            else if (CardFace == CardFace.Jack || CardFace == CardFace.Queen || CardFace == CardFace.King)
            {
                value = 10;
            }

            else
            {
                value = CardFace;
            }

            return value;
        }
    }
}