using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Student
    {
        public int IDNumber { get; private set; }
        public string Name { get; set; }

        // ? means might be null
        public string? Phone { get; set; }
        public string? Email { get; set; }

        static int NextIDNumber = 1_000_000;

        public Student(string name, string phone = "", string email = "")
        {
            Name = name;
            Phone = phone;
            Email = email;
            IDNumber = NextIDNumber++;
        }

        public override string ToString()
        {
            return $"{IDNumber}: {Name}";
        }

        public static int ChargeTutitionPerCredit()
        {
            return 675;
        }

    }
}
