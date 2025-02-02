﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface SimpleCalculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return (a + b);
        }
        public double Subtract(double a, double b)
        {
            return (a - b);
        }
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Divide(double a, int b)
        {
            return (a / b);
        }

    }
}
