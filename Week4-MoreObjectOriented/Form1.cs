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
            polygons.Add(new Rectangle("Rectangle", int.Parse(lengthTextBox.Text), int.Parse(widthTextBox.Text)));
            updatePolygonLabel();
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
            foreach ( var polygon in polygons)
            {
                polygonLabel.Text += polygon;
            }
        }
    }
}