using System.Globalization;
using System.Numerics;

namespace Week3_ObjectOrientedProgramming
{
    public partial class Form1 : Form
    {

        Rectangle rectangle;
        public Form1()
        {
            InitializeComponent();
            Circle circle = new()
            {
                Radius = 10,
                Color = "Blue"
            };
            circleLabel.Text = $"Circle Radius: {circle.Radius} - Color: {circle.Color}";

            Vehicle car = new("Jeep", "Wrangler", "Red", 10, 25);
            car.KilometersPerLiter = -5;
            
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