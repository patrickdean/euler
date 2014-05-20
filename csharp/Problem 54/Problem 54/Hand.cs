using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_54
{
    public class Hand
    {
        private List<Card> _cards;
        public ScoreType Score { get; set; }
        public int TieBreakValue { get; set; }
        public List<Card> Cards { get { return _cards; } }
        public Card.Faces HighCard { get; set; }

        public Hand()
        {
            _cards = new List<Card>();
            Score = ScoreType.None;
            TieBreakValue = 0;
        }

        public void Add(Card c)
        {
            _cards.Add(c);
            _cards.Sort();
        }
    }
}