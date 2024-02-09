namespace TexasHoldem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<PokerHand> list = new List<PokerHand>();
            list.Add(new PokerHand());
            list.Sort();
        }
    }
}