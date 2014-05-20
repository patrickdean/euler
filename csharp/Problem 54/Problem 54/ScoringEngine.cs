using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_54
{
    public enum ScoreType
    {
        None = 0,
        Pair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse = 8,
        FourOfAKind = 25,
        StraightFlush = 50,
        RoyalFlush = 250
    }

    public struct Score : IComparable<Score>
    {
        public ScoreType Type { get; set; }
        public int TieBreak { get; set; }
        public Card.Faces HighCard { get; set; }

        public Score(ScoreType type, int tieBreak, Card.Faces high)
            : this()
        {
            Type = type;
            TieBreak = tieBreak;
            HighCard = high;
        }

        public int CompareTo(Score score)
        {
           return this.Type.CompareTo(score.Type);
        }
    }

    public static class ScoringEngine
    {
        public static void GetScore(Hand hand)
        {
            List<Score> scores = new List<Score>();
            hand.Cards.Sort();

            scores.Add(new Score(ScoreType.None, (int)hand.Cards[4].Face, hand.Cards[3].Face));
                        
            Score twoPair = IsTwoPair(hand.Cards);
            Score threeOfAKind = IsThreeOfAKind(hand.Cards);
            Score fourOfAKind = IsFourOfAKind(hand.Cards);
            Score straight = IsStraight(hand.Cards);
            Score flush = IsFlush(hand.Cards);

            scores.Add(IsPair(hand.Cards));
            scores.Add(twoPair);
            scores.Add(threeOfAKind);
            scores.Add(fourOfAKind);
            scores.Add(straight);
            scores.Add(flush);

            if (twoPair.Type == ScoreType.TwoPair && threeOfAKind.Type == ScoreType.ThreeOfAKind && fourOfAKind.Type != ScoreType.FourOfAKind)
                scores.Add(new Score(ScoreType.FullHouse, threeOfAKind.TieBreak, (Card.Faces)twoPair.TieBreak));

            if (straight.Type == ScoreType.Straight && flush.Type == ScoreType.Flush)
            {
                if (hand.HighCard == Card.Faces.Ace)
                    scores.Add(new Score(ScoreType.RoyalFlush, (int)hand.HighCard, Card.Faces.Ace));
                else
                    scores.Add(new Score(ScoreType.StraightFlush, (int)hand.HighCard, hand.HighCard));
            }

            Score highScore = scores.Max();

            hand.Score = highScore.Type;
            hand.TieBreakValue = highScore.TieBreak;
            hand.HighCard = highScore.HighCard;
        }

        #region Helper Methods
        private static Score IsFlush(List<Card> hand)
        {
            for (int i = 0; i < 4; i++)
                if (hand[i].Suit != hand[i + 1].Suit)
                    return new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);

            return new Score(ScoreType.Flush, (int)hand[4].Face, hand[3].Face); 
        }

        private static Score IsStraight(List<Card> hand)
        {
            for (int i = 0; i < 4; i++)
                if (hand[i].Face + 1 != hand[i + 1].Face)
                    return new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);
            
            return new Score(ScoreType.Straight, (int)hand[4].Face, hand[3].Face);
        }

        private static Score IsTwoPair(List<Card> hand)
        {
            Score score = new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);
            if (hand[0].Face == hand[1].Face && hand[2].Face == hand[3].Face ||
                hand[1].Face == hand[2].Face && hand[3].Face == hand[4].Face ||
                hand[0].Face == hand[1].Face && hand[3].Face == hand[4].Face)
            {
                score.Type = ScoreType.TwoPair;
                score.TieBreak = (int)hand[3].Face;
                score.HighCard = hand[1].Face;
            }

            return score;
        }

        private static Score IsFourOfAKind(List<Card> hand)
        {
            Score score = new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);

            for (int i = 0; i <= 1; i++)
                if (hand[i].Face == hand[i + 1].Face && hand[i + 1].Face == hand[i + 2].Face && hand[i + 2].Face == hand[i + 3].Face)
                {
                    score.Type = ScoreType.FourOfAKind;
                    score.TieBreak = (int)hand[i].Face;
                    if (i == 0)
                        score.HighCard = hand[4].Face;
                    else
                        score.HighCard = hand[0].Face;
                }

            return score;
        }

        private static Score IsThreeOfAKind(List<Card> hand)
        {
            Score score = new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);

            for (int i = 0; i <= 2; i++)
                if (hand[i].Face == hand[i + 1].Face && hand[i + 1].Face == hand[i + 2].Face)
                {
                    score.Type = ScoreType.ThreeOfAKind;
                    score.TieBreak = (int)hand[i].Face;

                    if (i == 2)
                    {
                        score.HighCard = hand[1].Face;
                    }
                    else
                        score.HighCard = hand[4].Face; break;
                }

            return score;
        }

        private static Score IsPair(List<Card> hand)
        {
            Score score = new Score(ScoreType.None, (int)hand[4].Face, hand[3].Face);

            for (int i = 0; i <= 3; i++)
                if (hand[i].Face == hand[i + 1].Face)
                {
                    score.Type = ScoreType.Pair;
                    score.TieBreak = (int)hand[i].Face;

                    if (i == 3)
                        score.HighCard = hand[2].Face;
                    else
                        score.HighCard = hand[4].Face;
                }
            return score;
        }
        #endregion
    }
}