
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace GinRummy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form wide data declarations

        Deck myDeck = new GinRummy.Deck();
        public static Card pickedCard;
        const int sizeOfHand = 7;
        List<Card> autoHand = new List<Card>();
        List<Card> discardPile = new List<Card>();
        List<Card> usersHand = new List<Card>();

        private void btnDeal_Click(object sender, EventArgs e)
        {

            myDeck.Shuffle();

            // places a face-down card image in the form to represent the un-used deck
            pbDeck.Image = Image.FromFile(@"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\GinRummy\Cards\card_back.png");

            // deals cards to user and computer - displaying users card in the form
            foreach (PictureBox pb in panelMyDeck.Controls)
            {
                // deal a card to the user
                dealCard(pb, usersHand);  

                // deal a card to the computer - not displayed
                pickedCard = myDeck.Deal();
                autoHand.Add(pickedCard);
            }

            // flip the top card from the deck face up to start the discard pile
            dealCard(pbDiscard, discardPile);

            txtUserScore.Text = txtComputerScore.Text = "0";
        }

        private void pbDeck_Click(object sender, EventArgs e)
        {
            dealCard(pbMyHand8, usersHand);
        }

        private void dealCard(PictureBox pb, List <Card> cardList)
        {
            // deal a card to the user,
            Card c = myDeck.Deal();
            cardList.Add(c);

            displayCard(pb, c);
        }

        private void pbDiscard_Click(object sender, EventArgs e)
        {
            Card topDiscard = discardPile[discardPile.Count - 1];
            discardPile.Remove(topDiscard);

            // display card under top card of discard pile
            if (discardPile.Count == 0)
                pbDiscard.Image = null;
            else
            {
                Card newDiscard = discardPile[discardPile.Count - 1];
                pbDiscard.Image = Image.FromFile(newDiscard.filePath);
                pbDiscard.ImageLocation = newDiscard.filePath;
            }

            usersHand.Add(topDiscard);
            string suit = topDiscard.suitToString(topDiscard.suit);
            string fileName = topDiscard.rank + "_of_" + suit + ".png";
            pbMyHand8.Image = Image.FromFile(topDiscard.filePath);
            pbMyHand8.ImageLocation = topDiscard.filePath;

            
        }

        private void pbMyHand1_Click(object sender, EventArgs e)
        {
            passCardToForm2(pbMyHand1.ImageLocation);
        }

        private void pbMyHand2_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand2.ImageLocation);
        }

        private void pbMyHand3_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand3.ImageLocation);
        }

        private void pbMyHand4_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand4.ImageLocation);
        }

        private void pbMyHand5_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand5.ImageLocation);
        }

        private void pbMyHand6_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand6.ImageLocation);
        }

        private void pbMyHand7_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand7.ImageLocation);
        }

        private void pbMyHand8_Click(object sender, EventArgs e)
        {
            passCardToForm2(this.pbMyHand8.ImageLocation);
        }

        private void passCardToForm2(string path)
        {
            if(pbMyHand8.Image == null)
            {
                MessageBox.Show("You need to begin your turn by choosing a card from the deck or the discard pile");
            }
            else
            {
                for (int i = 0; i < usersHand.Count; i++)
                {
                    if (usersHand[i].filePath == path)
                    {
                        Form2 frm2 = new Form2();
                        frm2.displayCard(usersHand[i]);

                        DialogResult result = frm2.ShowDialog();        // determined by the button that user clicks in Form 2

                        // user clicks "Discard" button
                        if (result == DialogResult.OK)
                        {
                            frm2.Close();
                            discard(usersHand[i], "up");

                        }

                        else if (result == DialogResult.No)
                        {
                            frm2.Close();
                            discard(usersHand[i], "up");
                            calcScores(addPoints(usersHand), txtUserScore);
                            calcScores(addPoints(autoHand), txtComputerScore);
                        }

                        else if (result == DialogResult.Yes)
                        {
                            frm2.Close();
                            discard(usersHand[i], "down");
                            calcScores(addPoints(usersHand), txtUserScore);
                            calcScores(addPoints(autoHand), txtComputerScore);
                        }

                        break;
                    }
                }
            }
             
        }

        private void discard(Card c, string face)
        {
            // displays card on top of discard pile
            if (face == "up")
            {
                pbDiscard.Image = Image.FromFile(c.filePath);
                pbDiscard.ImageLocation = c.filePath;

                foreach(PictureBox pb in panelMyDeck.Controls)
                {
                    if (pb.ImageLocation == c.filePath)
                    {
                        pb.Image = Image.FromFile(pbMyHand8.ImageLocation);
                        break;
                    }
                }
                pbMyHand8.Image = null;

                usersHand.Remove(c);

                discardPile.Add(c);
            }
            else if (face == "down")
            {
                string filePath = @"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\GinRummy\Cards\card_back.png";
                pbDiscard.Image = Image.FromFile(filePath);
                pbDiscard.ImageLocation = filePath;

                foreach (PictureBox pb in panelMyDeck.Controls)
                {
                    if (pb.ImageLocation == c.filePath)
                    {
                        pb.Image = Image.FromFile(pbMyHand8.ImageLocation);
                    }
                }
                pbMyHand8.Image = null;

                usersHand.Remove(c);

                discardPile.Add(c);
            }
            
        }

        private void calcScores(int score, TextBox txt)
        {
            int total = Convert.ToInt32(txt.Text);

            total += score;

            txt.Text = total.ToString();
        }

        static int addPoints(List<Card> hand)
        {
            identifyRuns(hand);
            identifyThreeAndFourOfAKinds(hand);

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
                        if (count >= 3)
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

        private void btnShowHands_Click(object sender, EventArgs e)
        {
            // clear each list box 
            listUsersHand.Items.Clear();
            listAutoHand.Items.Clear();
            listDiscard.Items.Clear();

            // display current contents of each hand and discard pile in it's list box
            sortBySuitAndRank(usersHand);
            displayHand(usersHand, listUsersHand);
            sortBySuitAndRank(autoHand);
            displayHand(autoHand, listAutoHand);
            displayHand(discardPile, listDiscard); 
        }

        private void displayCard(PictureBox pb, Card c)
        {
            // display card in PictureBox from a .png file
            pb.Image = c.GetCardImage(c.rank, c.suit);
            pb.ImageLocation = c.filePath;                  // explicitly sets file path to the PictureBox
        }

        private void displayHand (List<Card> list, ListBox lb)
        {
            foreach (Card c in list)
            {
                lb.Items.Add(c.rank + " of " + c.suitToString(c.suit));
            }
        }

        private void printCardList(List<Card> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(list[i].rank + " of " + list[i].suitToString(list[i].suit) + "\n");
                
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in panelMyDeck.Controls)
            {
                pb.Image = null;
                pb.ImageLocation = null;
            }

            pbMyHand8.Image = null;
            pbMyHand8.ImageLocation = null;

            pbDiscard.Image = null;
            pbDiscard.ImageLocation = null;

            autoHand.Clear();
            usersHand.Clear();
            discardPile.Clear();

            listAutoHand.Items.Clear();
            listUsersHand.Items.Clear();
            listDiscard.Items.Clear();

            txtComputerScore.Text = "0";
            txtUserScore.Text = "0";
        }

        private void autoDraw(Card discard)
        {
            List<Card> wantedCards = new List<Card>();

            List<Card> temp = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                foreach (Card c in autoHand)
                {
                    if (c.suit == i)
                    {
                        temp.Add(c);
                    } 
                }
                if (temp.Count > 1)
                {
                    sortByRank(temp);
                    for(int j = 0; j < temp.Count; j++)
                    {
                        if(temp[j].rank == temp)
                    }
                }
            }
                

















            List<Card> temp = new List<Card>();
            foreach(Card c in autoHand)
            {
                if (c.suit == discard.suit)
                {
                    if(c.rank == discard.rank - 1 || c.rank == discard.rank + 1)
                    temp.Add(c);
                }
            }

            if(temp.Count > 1)
            {
                sortByRank(temp);

                int count = 1;

                // check adjacent pairs to see if they are consecutive ranks
                for (int i = 0; i < temp.Count - 1; i++)
                {

                    if (temp[i].rank == (temp[i + 1].rank - 1))
                    {
                        count++;
                    }
                }
            }

            
        }
    }
}
