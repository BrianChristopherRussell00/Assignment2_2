﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public static double CalculateArea( double Radius)
        {

            return Math.PI * (Radius*Radius);

        }


    }


}
