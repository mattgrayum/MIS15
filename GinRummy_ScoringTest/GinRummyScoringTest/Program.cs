using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinRummyScoringTest
{
    class Program
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

            public bool isEqual(Card c)
            {
                if(this.rank == c.rank && this.suit == c.suit)
                {
                    return true;
                }
                return false;
            }

            //gets image from .png file
            //public Image GetCardImage(int rank, int suit)
            //{
            //    return Image.FromFile(this.filePath);
            //}

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

        static void Main(string[] args)
        {
            string answer = "y";
            do
            {
                Random rn = new Random();
                List<Card> hand = new List<Card>()
            {
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
                new Card(rn.Next(1,14), rn.Next(1,5)),
              
            };
                bool switched;
                do
                {
                    switched = false;
                    for (int outer = 0; outer < hand.Count - 1; outer++)
                    {
                        for (int inner = outer + 1; inner < hand.Count; inner++)
                        {
                            if (hand[outer].rank == hand[inner].rank && hand[outer].suit == hand[inner].suit)
                            {
                                hand[inner] = new Card(rn.Next(1, 14), rn.Next(1, 5));
                                switched = true;
                            }
                        }
                    }
                } while (switched == true);

                

                foreach (Card c in hand)
                {
                    Console.WriteLine("        " + c.rank + " of " + c.suitToString(c.suit) + "\n");
                }
                Console.ReadKey();

                calcScores(addPoints(hand));

                Console.WriteLine("     Another? (y or n): ");
                answer = Console.ReadLine();

            }while (answer == "y") ;
            
    }

        static void identifyThreeAndFourOfAKinds(List<Card> hand)
        {
            List<Card> temp = new List<Card>();

            // for each rank of card...
            for (int i = 1; i < 14; i++)
            {
                temp.Clear();

                // iterate through hand and accumulate matching ranks
                foreach (Card c in hand)
                {

                    if (c.rank == i && c.isScored)
                    {
                        temp.Add(c);
                    }
                }

                // if there are 3 or more of a particular rank, change their isScored property to false
                if (temp.Count >= 3)
                {
                    for (int j = 0; j < temp.Count; j++)
                    {
                        foreach (Card c in hand)
                        {
                            // set property isScored for each card in the hand that is part of 
                            // the three- or four-of-a-kind to false
                            if (c.isEqual(temp[j]))
                            {
                                c.isScored = false;
                            }
                        }
                    }
                }
            }
        }

        static void identifyRuns(List<Card> hand)
        {
            List<Card> possibleRun = new List<Card>();

            // for each suit...
            for (int i = 1; i < 5; i++)
            {
                possibleRun.Clear();

                // accumulate the number of cards in the hand of a particular suit
                foreach (Card c in hand)
                {
                    if (c.suit == i)
                    {
                        possibleRun.Add(c);
                    }
                }

                if (possibleRun.Count != 0)
                {
                    // if there are 3 or more cards of one suit...
                    if (possibleRun.Count >= 3)
                    {
                        // sort the list in ascending order by rank
                        sortBySuitAndRank(possibleRun);

                        int count = 1;

                        // check adjacent pairs to see if they are consecutive ranks
                        for (int o = 0; o < possibleRun.Count - 1; o++)
                        {

                            if (possibleRun[o].rank == (possibleRun[o + 1].rank - 1))
                            {
                                count++;
                            }

                            else
                            {
                                //if less than three consecutive ranks...
                                if (count < 3)
                                {
                                    count = 1;
                                }

                                // if three or more in consecutive order...
                                else
                                {
                                    for (int m = 0; m < count; m++)
                                    {
                                        foreach (Card c in hand)
                                        {
                                            // set property isScored for each card in the hand that is part of a the run to false
                                            if (c.isEqual(possibleRun[m]))
                                            {
                                                c.isScored = false;
                                            }
                                        }
                                    }
                                    count = 1;
                                }
                            } 
                        }
                        if(count >= 3)
                        {
                            for (int m = 0; m < count; m++)
                            {
                                foreach (Card c in hand)
                                {
                                    // set property isScored for each card in the hand that is part of a the run to false
                                    if (c.isEqual(possibleRun[m]))
                                    {
                                        c.isScored = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void sortBySuitAndRank(List<Card> list)
        {
            // sorts a list of cards by suit and then by rank

            int i, outer;

            bool swap = true;

            for (outer = list.Count; outer > 0 && swap == true; outer--)
            {
                swap = false;

                for (i = 0; i < outer - 1; i++)
                {
                    if (list[i].suit > list[i + 1].suit)
                    {
                        swapCards(list, i);
                        swap = true;
                    }
                }
            }

            swap = true;

            for (outer = list.Count; outer > 0 && swap == true; outer--)
            {
                swap = false;

                for (i = 0; i < outer - 1; i++)
                {
                    if (list[i].suit == list[i + 1].suit && list[i].rank > list[i + 1].rank)
                    {
                        swapCards(list, i);
                        swap = true;
                    }
                }
            }
        }

        static void sortByRank(List<Card> list)
        {
            int i, outer;

            bool swap = true;

            for (outer = list.Count; outer > 0 && swap == true; outer--)
            {
                swap = false;

                for (i = 0; i < outer - 1; i++)
                {
                    if (list[i].rank > list[i + 1].rank)
                    {
                        swapCards(list, i);
                        swap = true;
                    }
                }
            }
        }

        static void swapCards(List<Card> list, int index)
        {
            Card temp = new Card(1, 1);
            temp = list[index];
            list[index] = list[index + 1];
            list[index + 1] = temp;

        }

        static void calcScores(int userScore)
        {
            int userTotal = 0;
            
            userTotal += userScore;
            
            Console.WriteLine("\n\n     Score: " + userTotal + "\n\n");
        }

        static int addPoints(List<Card> hand)
        {
            identifyRuns(hand);
            identifyThreeAndFourOfAKinds(hand);

            foreach (Card c in hand)
            {
                Console.WriteLine("     " + c.rank + " --> isScored? " + c.isScored);
            }

            int points_1 = 0;
            foreach (Card c in hand)
            {
                if (c.isScored == true && c.rank > 10)
                {
                    points_1 += 10;
                }
                else if (c.isScored == true)
                {
                    points_1 += c.rank;
                }
            }

            identifyThreeAndFourOfAKinds(hand);
            identifyRuns(hand);

            foreach (Card c in hand)
            {
                Console.WriteLine("     " + c.rank + " --> isScored? " + c.isScored);
            }

            int points_2 = 0;
            foreach (Card c in hand)
            {
                if (c.isScored == true && c.rank > 10)
                {
                    points_2 += 10;
                }
                else if (c.isScored == true)
                {
                    points_2 += c.rank;
                }
            }

            return Math.Min(points_1, points_2);

        }

        static bool notAdjacent(int x, int y)
        {
            if (x == y - 1)
            {
                return false;
            }
            return true;
        }

        static void removeARun (List<Card> list, List<Card> hand)
        {
            if (list.Count > 0)
            {
                // remove a run of 3 or more from the hand
                for (int outer = 0; outer < list.Count; outer++)
                {
                    for (int inner = 0; inner < hand.Count; inner++)
                    {
                        if (hand[inner] == list[outer])
                        {
                            hand.Remove(list[outer]);
                        }

                    }
                }
            }
        }
    }
}
