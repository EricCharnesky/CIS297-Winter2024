namespace Yahtzee
{
    public partial class Form1 : Form
    {

        private YahtzeeScorecard player1;
        private YahtzeeScorecard player2;
        private YahtzeeScorecard currentPlayer;
        private YahtzeeDice dice;
        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        private void newDice()
        {
            dice = new YahtzeeDice();

            die1Label.Text = "";
            die2Label.Text = "";
            die3Label.Text = "";
            die4Label.Text = "";
            die5Label.Text = "";

            holdDie1CheckBox.Checked = false;
            holdDie2CheckBox.Checked = false;
            holdDie3CheckBox.Checked = false;
            holdDie4CheckBox.Checked = false;
            holdDie5CheckBox.Checked = false;

            score1sButton.Enabled = false;
            score2sButton.Enabled = false;

        }

        private void UpdateLabels()
        {
            currentPlayerLabel.Text = "Current Player: " + (currentPlayer == player1 ? "Player 1" : "Player 2");

            rollsRemainingLabel.Text = (3 - dice.NumberOfTimesRolled).ToString();

            YahtzeeScorecard possibleScores = dice.GetPossibleScores();

            if (currentPlayer.OnesScore == null)
            {
                onesScoreLabel.Text = possibleScores.OnesScore.ToString();
            }
            if (currentPlayer.TwosScore == null)
            {
                twosScoreLabel.Text = possibleScores.TwosScore.ToString();
            }

            score1sButton.Enabled = currentPlayer.OnesScore == null;
            score2sButton.Enabled = currentPlayer.TwosScore == null;

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dice.Roll();

            die1Label.Text = dice.Die1Value.ToString();
            die2Label.Text = dice.Die2Value.ToString();
            die3Label.Text = dice.Die3Value.ToString();
            die4Label.Text = dice.Die4Value.ToString();
            die5Label.Text = dice.Die5Value.ToString();

            UpdateLabels();
        }

        private void holdDie1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie1 = holdDie1CheckBox.Checked;
        }

        private void holdDie2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie2 = holdDie2CheckBox.Checked;
        }

        private void holdDie3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie3 = holdDie3CheckBox.Checked;
        }

        private void holdDie4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie4 = holdDie4CheckBox.Checked;
        }

        private void holdDie5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie5 = holdDie5CheckBox.Checked;
        }

        private void score1sButton_Click(object sender, EventArgs e)
        {
            currentPlayer.OnesScore = dice.GetPossibleScores().OnesScore;
            nextPlayer();
        }

        private void nextPlayer()
        {
            // currentPlayer = currentPlayer == player1 ? player2 : player1;
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }



            onesScoreLabel.Text = currentPlayer.OnesScore == null ? "" : currentPlayer.OnesScore.ToString();
            twosScoreLabel.Text = currentPlayer.TwosScore == null ? "" : currentPlayer.TwosScore.ToString();

            newDice();
            UpdateLabels();
        }

        private void score2sButton_Click(object sender, EventArgs e)
        {
            currentPlayer.TwosScore = dice.GetPossibleScores().TwosScore;
            nextPlayer();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            player1 = new YahtzeeScorecard();
            player2 = new YahtzeeScorecard();
            currentPlayer = player1;
            newDice();
            UpdateLabels();

            score1sButton.Enabled = false;
            score2sButton.Enabled = false;
        }
    }
}