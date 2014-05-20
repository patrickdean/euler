using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_54
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myFile = new StreamReader("poker.txt");
            
            int player1wins = 0;

            Hand player1 = new Hand();
            Hand player2 = new Hand();
            List<Card> twoHands = new List<Card>();

            while (!myFile.EndOfStream)
            {
                player1 = new Hand();
                twoHands = ParseString(myFile.ReadLine());


                for (int i = 0; i < 5; i++)
                {
                    player1.Add(twoHands[0]);
                    twoHands.RemoveAt(0);
                }

                player2 = new Hand();

                for (int i = 0; i < 5; i++)
                {
                    player2.Add(twoHands[0]);
                    twoHands.RemoveAt(0);
                }

                ScoringEngine.GetScore(player1);
                ScoringEngine.GetScore(player2);

                if (player1.Score > player2.Score)
                {
                    player1wins++;
                }
                else if (player1.Score == player2.Score)
                {
                    if (player1.TieBreakValue > player2.TieBreakValue)
                    {
                        player1wins++;
                    }
                    else
                        if (player1.TieBreakValue == player2.TieBreakValue)
                        {
                            if (player1.HighCard > player2.HighCard)
                                player1wins++;
                        }
                }

            }

            myFile.Close();

            Console.WriteLine("Player 1 wins: " + player1wins);
        }

        private static List<Card> ParseString(string p)
        {
            List<Card> theHands = new List<Card>();

            string[] cards = p.Split(' ');

            foreach (string s in cards)
                theHands.Add(new Card(s));

            return theHands;
        }

    }
}