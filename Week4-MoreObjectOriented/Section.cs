using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Section
    {
        private List<Student> Students;
        string Instructor {  get; set; }
        string CourseCode { get; set; }

        public Section(string instructor, string courseCode) {
            Instructor = instructor;
            CourseCode = courseCode;
            Students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return null;
           // return new List<Student>(Students);
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                Students.Add(student);
            }
        }
    }
}
