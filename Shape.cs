using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    internal class Shape
    {
        public Guid ShapeId { get; set; }

        public string ShapeName { get; set; }

        public string ShapeColor { get; set; }


        public static double CalculateArea(double length, double width) {     
        
        return length * width;
        
        }

    }
}
