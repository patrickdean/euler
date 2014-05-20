using System;
namespace Problem_54
{
    public class Card : IComparable<Card>
    {
        public enum Faces
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        public enum Suits
        {
            Diamond, Spade, Heart, Club
        }
        public static Card CreateCard(Faces face, Suits suit)
        {
            return new Card(face, suit);
        }

        Faces face;
        Suits suit;

        public Card(Faces face, Suits suit)
        {
            Face = face;
            Suit = suit;
        }

        public Card(string s)
        {
            switch (s[0])
            {
                case 'A': Face = Faces.Ace;
                    break;
                case '2': Face = Faces.Two;
                    break;
                case '3': Face = Faces.Three;
                    break;
                case '4': Face = Faces.Four;
                    break;
                case '5': Face = Faces.Five;
                    break;
                case '6': Face = Faces.Six;
                    break;
                case '7': Face = Faces.Seven;
                    break;
                case '8': Face = Faces.Eight;
                    break;
                case '9': Face = Faces.Nine;
                    break;
                case 'T': Face = Faces.Ten;
                    break;
                case 'J': Face = Faces.Jack;
                    break;
                case 'Q': Face = Faces.Queen;
                    break;
                case 'K': Face = Faces.King;
                    break;
            }

            switch (s[1])
            {
                case 'C': Suit = Suits.Club;
                    break;
                case 'S': Suit = Suits.Spade;
                    break;
                case 'D': Suit = Suits.Diamond;
                    break;
                case 'H': Suit = Suits.Heart;
                    break;
            }
        }


        public Faces Face
        {
            get { return face; }
            set { face = value; }
        }
        public Suits Suit
        {
            get { return suit; }
            set { suit = value; }
        }
                
        public int Value
        {
            get { return GetValue(); }
        }
        public override string ToString()
        {
           // return (face.ToString() + " of " + suit.ToString());
            return ShortString();
        }

        public string ShortString()
        {
            string shortStr = "";

            if ((int)Face >= 10)
                shortStr = "" + face.ToString()[0] + suit.ToString()[0];
            else
                shortStr = "" + (int)face + suit.ToString()[0];
            
            return shortStr;
        }

        public int GetValue(bool getHigh = false)
        {
            switch (face)
            {
                case Faces.Ace:
                    if (getHigh)
                        return 11;
                    else
                        return 1;
                case Faces.Two:
                    return 2;
                case Faces.Three:
                    return 3;
                case Faces.Four:
                    return 4;
                case Faces.Five:
                    return 5;
                case Faces.Six:
                    return 6;
                case Faces.Seven:
                    return 7;
                case Faces.Eight:
                    return 8;
                case Faces.Nine:
                    return 9;
                case Faces.Ten:
                    return 9;
                case Faces.Jack:
                    return 10;
                case Faces.Queen:
                    return 10;
                case Faces.King:
                    return 10;
                default:
                    Console.WriteLine("Something bad happened, this card has NO value!: {0}", face);
                    return 0;

            }
        }

        public int CompareTo(Card card)
        {
            return this.Face.CompareTo(card.Face);
        }
    }
}