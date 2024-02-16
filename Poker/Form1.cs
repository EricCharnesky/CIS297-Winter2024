using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newHandButton_Click(object sender, EventArgs e)
        {
            PokerHand hand = new PokerHand();

            List<Card> cards = new List<Card>();
            foreach (Card.Face face in Enum.GetValues(typeof(Card.Face)))
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    cards.Add(new Card(face, suit));
                }
            }
            Random random = new Random();

            for (int card = 0; card < 5; card++)
            {
                int randomIndex = random.Next(0, cards.Count);

                hand.Cards.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex);
            }

            handLabel.Text = hand.ToString();

            // from Chatgpt

            // Using LINQ to group by FaceValue and count occurrences
            var faceValueCounts = hand.Cards.GroupBy(card => card.face)
                                       .Select(group => new { FaceValue = group.Key, Count = group.Count() })
                                       .OrderBy(x => x.FaceValue); // Optional: ordering by FaceValue for display


            faceCountsLabel.Text = "";
            // Display the results
            foreach (var faceValueCount in faceValueCounts)
            {
                faceCountsLabel.Text += $"Face Value: {faceValueCount.FaceValue}, Count: {faceValueCount.Count} {Environment.NewLine}";
            }
        }
    }
}