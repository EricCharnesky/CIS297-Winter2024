namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateLabel();
        }

        private void updateLabel()
        {
            clickMeLabel.Text += $"Hello {nameTextBox.Text}!" + Environment.NewLine + sequenceListBox.Text;
        }

        // asked umgpt "using a winform textbox, how do I trigger an event when the enter key is pressed?"
        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // https://stackoverflow.com/questions/12318164/enter-key-press-in-c-sharp
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                updateLabel();
            }
        }

        private void sequenceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLabel();
        }
    }
}