using System.Globalization;

namespace Week3_ObjectOrientedProgramming
{
    public partial class Form1 : Form
    {

        Rectangle rectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void makeRectangleButton_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.SetLength(int.Parse(lengthTextBox.Text));
            rectangle.SetWidth(int.Parse(widthTextBox.Text));
            updateRectangleLabels();
        }

        private void updateRectangleLabels()
        {
            rectangleLabel.Text = rectangle.ToString();
            areaLabel.Text = $"Area: {rectangle.GetArea()}";
            perimeterLabel.Text = $"Perimter: {rectangle.Perimeter}";
        }

        private void lengthSlider_Scroll(object sender, EventArgs e)
        {
            rectangle.SetLength(lengthSlider.Value);
            updateRectangleLabels();
        }
    }
}