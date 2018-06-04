using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GinRummy
{
    public class Card
    {
        public int rank;
        public int suit;
        public string filePath;
        public bool isScored = true;

        //kinds of suits
        enum Suits : int
        {
            diamonds = 1,
            clubs = 2,
            hearts = 3,
            spades = 4
        };

        //kinds of ranks
        enum Ranks : int
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        };

        public Card(int rank, int suit)
        {
            isValidRank(rank);
            isValidSuit(suit);
            this.rank = rank;
            this.suit = suit;
            filePath = @"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\GinRummy\Cards\"
                        + rank + "_of_" + this.suitToString(suit) + ".png";
        }

        public int getSuit()
        {
            return suit;
        }

        public int getRank()
        {
            return rank;
        }

        public string suitToString(int suit)
        {
            return Enum.GetName(typeof(Suits), suit);
        }

        public string rankToString(int rank)
        {
            return Enum.GetName(typeof(Ranks), rank);
        }

        //gets image from .png file
        public Image GetCardImage(int rank, int suit)
        {
            return Image.FromFile(this.filePath);
        }

        public bool isEqual(Card c)
        {
            if (this.rank == c.rank && this.suit == c.suit)
            {
                return true;
            }
            return false;
        }

        public static bool isValidSuit(int suit)
        {
            if ((int)Suits.diamonds <= suit && suit <= (int)Suits.spades)
                return true;
            else return false;
        }

        public static bool isValidRank(int rank)
        {
            if ((int)Ranks.Ace <= rank && rank <= (int)Ranks.King)
                return true;
            else return false;
        }
    }

    public class Deck
    {
        const int sizeOfDeck = 52;
        const int numOfSuits = 4;
        const int numOfRanks = 13;
        public List<Card> deck = new List<Card>();
        public List<Card> dealt = new List<Card>();

        public Deck()
        {
            for (int suit = 0; suit < numOfSuits; suit++)
            {
                for (int rank = 0; rank < numOfRanks; rank++)
                {
                    this.deck.Add(new Card(rank + 1, suit + 1));
                }
            }
        }

        public void Shuffle()
        {
            // Deck is shuffled seven times

            // An homage to my Mom who told me once that shuffling seven times would 
            // produce a randomly shuffled deck.

            for (int i = 0; i < 7; i++)
            {

                int n = this.deck.Count;
                while (n > 1)
                {
                    n--;
                    Random rn = new Random();
                    int rndIndex = rn.Next(n + 1);
                    Card c = this.deck[rndIndex];
                    this.deck[rndIndex] = this.deck[n];
                    this.deck[n] = c;
                }
            }
        }

        public Card Deal()
        {
            // get random index number
            Random rn = new Random();
            int rndIndex = rn.Next(this.deck.Count);

            // use random index number to pick random card from deck and add it to a list of dealt cards
            Card dealtCard = this.deck[rndIndex];
            this.deck.Remove(dealtCard);
            this.dealt.Add(dealtCard);
            return dealtCard;
        }

    }

    //public class Hand
    //{
    //    List<Card> hand = new List<Card>();


    //    public Hand(List<Card> list)
    //    {
    //        hand = list;

    //    }

    //    public int RankBelowStraight(int suit)
    //    {
    //        List<Card> matchingSuitList = new List<Card>();

    //        // accumulate the number of cards in the hand of a particular suit
    //        foreach (Card c in hand)
    //        {
    //            if (c.suit == suit)
    //            {
    //                matchingSuitList.Add(c);
    //            }
    //        }

    //        if (matchingSuitList.Count != 0)
    //        {
    //            // if there are 3 or more cards of one suit...
    //            if (matchingSuitList.Count >= 3)
    //            {
    //                    // sort the list in ascending order by rank
    //                    SortBySuitAndRank(matchingSuitList);

    //                    int count = 1;

    //                    // check adjacent pairs to see if they are consecutive ranks
    //                    for (int o = 0; o < matchingSuitList.Count - 1; o++)
    //                    {

    //                        if (matchingSuitList[o].rank == (matchingSuitList[o + 1].rank - 1))
    //                        {
    //                            count++;
    //                        }

    //                        else
    //                        {
    //                            //if less than three consecutive ranks...
    //                            if (count < 3)
    //                            {
    //                                count = 1;
    //                            }

    //                            // if three or more in consecutive order...
    //                            else
    //                            {
    //                                for (int m = 0; m < count; m++)
    //                                {
    //                                    foreach (Card c in hand)
    //                                    {
    //                                        // set property isScored for each card in the hand that is part of a the run to false
    //                                        if (c.isEqual(matchingSuitList[m]))
    //                                        {
    //                                            c.isScored = false;
    //                                        }
    //                                    }
    //                                }
    //                                count = 1;
    //                            }
    //                        }
    //                    }
    //                    if (count >= 3)
    //                    {
    //                        for (int m = 0; m < count; m++)
    //                        {
    //                            foreach (Card c in hand)
    //                            {
    //                                // set property isScored for each card in the hand that is part of a the run to false
    //                                if (c.isEqual(matchingSuitList[m]))
    //                                {
    //                                    c.isScored = false;
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    public void SortBySuitAndRank(List<Card> list)
    //    {
    //        // sorts a list of cards by suit and then by rank

    //        int i, outer;

    //        bool swap = true;

    //        for (outer = list.Count; outer > 0 && swap == true; outer--)
    //        {
    //            swap = false;

    //            for (i = 0; i < outer - 1; i++)
    //            {
    //                if (list[i].suit > list[i + 1].suit)
    //                {
    //                    swapCards(list, i);
    //                    swap = true;
    //                }
    //            }
    //        }

    //        swap = true;

    //        for (outer = list.Count; outer > 0 && swap == true; outer--)
    //        {
    //            swap = false;

    //            for (i = 0; i < outer - 1; i++)
    //            {
    //                if (list[i].suit == list[i + 1].suit && list[i].rank > list[i + 1].rank)
    //                {
    //                    swapCards(list, i);
    //                    swap = true;
    //                }
    //            }
    //        }
    //    }
    //}
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm1 = new GinRummy.Form1();
            Application.Run(frm1);


        }
    }
}
