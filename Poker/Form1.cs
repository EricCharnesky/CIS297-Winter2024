using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Poker
{
    public partial class Form1 : Form
    {
        Player currentPlayer;
        Player player1;
        Player player2;
        int pot;
        int round;
        List<Card> sharedCards;
        Deck deck;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            sharedCards = new List<Card>();
            currentPlayer = player1;
            betOrFoldButton.Enabled = false;
            checkOrCallButton.Enabled = false;
            pot = 0;
            round = 0;
            deck = new Deck();
        }

        private void newHandButton_Click(object sender, EventArgs e)
        {

            round = 0;
            deck = new Deck();

            sharedCards.Clear();

            Card player1Card1 = deck.DealCard();
            Card player2Card1 = deck.DealCard();

            Card player1Card2 = deck.DealCard();
            Card player2Card2 = deck.DealCard();

            player1.HoldemHand = new HoldemHand(player1Card1, player1Card2);
            player2.HoldemHand = new HoldemHand(player2Card1, player2Card2);

            // feels bad, but don't need copies?
            player1.HoldemHand.sharedShared = sharedCards;
            player2.HoldemHand.sharedShared = sharedCards;

            player1HandLabel.Text = player1.HoldemHand.ToString();
            player2HandLabel.Text = player2.HoldemHand.ToString();

            player1.Money--;
            player2.Money--;

            roundOverLabel.Text = "";

            pot = 2;

            newHandButton.Enabled = false;
            betOrFoldButton.Enabled = true;
            checkOrCallButton.Enabled = true;

            if (currentPlayer == player1)
            {
                currentPlayerLabel.Text = $"Current Player: Player 1";
            }
            else
            {
                currentPlayerLabel.Text = $"Current Player: Player 2";
            }



            updateMoneyLabels();


            //// from Chatgpt

            //// Using LINQ to group by FaceValue and count occurrences
            //var faceValueCounts = hand.Cards.GroupBy(card => card.face)
            //                           .Select(group => new { FaceValue = group.Key, Count = group.Count() })
            //                           .OrderBy(x => x.FaceValue); // Optional: ordering by FaceValue for display


            //faceCountsLabel.Text = "";
            //// Display the results
            //foreach (var faceValueCount in faceValueCounts)
            //{
            //    faceCountsLabel.Text += $"Face Value: {faceValueCount.FaceValue}, Count: {faceValueCount.Count} {Environment.NewLine}";
            //}
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            round++;



            if (checkOrCallButton.Text == "Call")
            {
                // TODO does the player have enough money?
                if (currentPlayer == player1)
                {
                    player2.Money--;
                    pot++;
                }
                else
                {
                    player1.Money--;
                    pot++;
                }

                betOrFoldButton.Text = "Bet";
                checkOrCallButton.Text = "Check";

                // round over
                if (round == 4)
                {
                    roundOver();
                }
            }
            if (round == 1)
            {
                sharedCards.Add(deck.DealCard());
                sharedCards.Add(deck.DealCard());
                sharedCards.Add(deck.DealCard());
            }
            else if (round == 2)
            {
                sharedCards.Add(deck.DealCard());

            }
            else if (round == 3)
            {
                sharedCards.Add(deck.DealCard());
            }
            else if (round == 4)
            {
                roundOver();
            }

            sharedCardsLabel.Text = "Shared Cards: ";
            foreach (Card card in sharedCards)
            {
                sharedCardsLabel.Text += card.ToString() + "\n";
            }
            updateMoneyLabels();
        }

        private void roundOver()
        {
            newHandButton.Enabled = true;
            betOrFoldButton.Enabled = false;
            checkOrCallButton.Enabled = false;

            if (player1.HoldemHand.CompareTo(player2.HoldemHand) > 0)
            {
                roundOverLabel.Text = "Player 1 wins!";
                player1.Money += pot;
                pot = 0;
            }
            else if (player1.HoldemHand.CompareTo(player2.HoldemHand) < 0)
            {
                roundOverLabel.Text = "Player 2 wins!";
                player2.Money += pot;
                pot = 0;
            }
            else
            {
                roundOverLabel.Text = "Tie!";
                player1.Money += pot / 2;
                player2.Money += pot / 2;
                pot = 0;
            }

            roundOverLabel.Text += $"\nPlayer 1 Hand: {player1.HoldemHand.GetBestPokerHand()}";
            roundOverLabel.Text += $"\nPlayer 2 Hand: {player2.HoldemHand.GetBestPokerHand()}";
        }

        private void updateMoneyLabels()
        {
            player1MoneyLabel.Text = $"Player 1 Money: ${player1.Money}";
            player2MoneyLabel.Text = $"Player 2 Money: ${player2.Money}";
            potLabel.Text = $"Pot: ${pot}";
        }

        private void betOrFoldButton_Click(object sender, EventArgs e)
        {
            if (betOrFoldButton.Text == "Bet")
            {
                betOrFoldButton.Text = "Fold";
                checkOrCallButton.Text = "Call";
                currentPlayer.Money--;
                pot++;
            }
            else
            {
                currentPlayer.Money += pot;
                pot = 0;
                betOrFoldButton.Text = "Bet";
                checkOrCallButton.Text = "Check";

                newHandButton.Enabled = true;
                betOrFoldButton.Enabled = false;
                checkOrCallButton.Enabled = false;
            }

            updateMoneyLabels();
        }
    }
}