using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        // Expression-bodied properties
        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Expression-bodied method to calculate area
        public double GetArea() => length * breadth;

        // NEW: Expression-bodied method to calculate perimeter
        public double GetPerimeter() => 2 * (length + breadth);

        // Expression-bodied method to show details
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
    }
}
