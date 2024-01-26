using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ObjectOrientedProgramming
{
    internal class Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; } = string.Empty;

        public double Area => Math.PI * Radius * Radius;

        public double Perimeter => Math.PI * Diameter;

        public double Diameter => Radius * 2;
    }
}
