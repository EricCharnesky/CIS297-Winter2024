using System.Text.Json.Serialization.Metadata;

namespace Week4_MoreObjectOriented
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            section = new Section("Charnesky", "CIS 297");
            polygons = new List<Polygon>();
        }

        Section section;

        List<Polygon> polygons;

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty)
            {
                section.AddStudent(new Student(nameTextBox.Text));
                nameTextBox.Text = string.Empty;
                studentLabel.Text = "Students: " + Environment.NewLine;


                // if it gets back null, create a new empty list
                List<Student> students = section.GetStudents() ?? new List<Student>();
                if (section != null)
                {
                    //var students = section.GetStudents();

                    // does the email address of the first student have an @
                    students?[0]?.Email?.Contains("@");
                    if (students != null)
                    {
                        foreach (Student student in students)
                        {
                            studentLabel.Text += student;
                            if (student.Email != null)
                            {
                                studentLabel.Text += "Email: " + student.Email;
                            }



                            studentLabel.Text += Environment.NewLine;
                        }
                    }

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                polygons.Add(new Rectangle("Rectangle", int.Parse(lengthTextBox.Text), int.Parse(widthTextBox.Text)));

                updatePolygonLabel();
            }
            catch (FormatException ex)
            {
                polygonLabel.Text = ex.Message;
            }
            catch(Exception ex)
            {
                polygonLabel.Text = ex.StackTrace;
            }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle("Triangle");
            triangle.SetSideLength(3, 0);
            triangle.SetSideLength(4, 1);
            triangle.SetSideLength(5, 2);
            polygons.Add(triangle);
            updatePolygonLabel();
        }

        private void updatePolygonLabel()
        {
            polygonLabel.Text = "Polygons: ";
            foreach (var polygon in polygons)
            {
                polygonLabel.Text += polygon + Environment.NewLine;

                // try and cast as a trapezoid
                if ( polygon.GetType() == typeof(Trapezoid))
                {
                    Trapezoid trapezoid = (Trapezoid)polygon;

                    if (trapezoid != null)
                    {
                        polygonLabel.Text += trapezoid.getTrapezoid() + Environment.NewLine;
                    }
                }


                var trapezoid2 = polygon as Trapezoid;

                if (trapezoid2 != null)
                {
                    polygonLabel.Text += trapezoid2.getTrapezoid() + Environment.NewLine;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // once we mark it as abstract, it doesn't work
            //polygons.Add(new Polygon(new Random().Next(1, 10), "generic polygon"));

            var trapezoid = new Trapezoid("Trapezoidy");
            trapezoid.SetSideLength(4, 0);
            trapezoid.SetSideLength(4, 2);
            trapezoid.SetSideLength(4, 1);
            trapezoid.SetSideLength(4, 3);
            polygons.Add(trapezoid);
            
            updatePolygonLabel();
        }
    }
}