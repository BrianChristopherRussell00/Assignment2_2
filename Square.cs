using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    internal class Square : Shape
    {
        public double LengthSide { get; set; }
        public static double CalculateArea(double LengthSide)
        {

            return LengthSide * LengthSide;

        }


    }
}
