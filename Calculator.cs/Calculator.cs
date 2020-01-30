using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    public class Calculator : ICalculator
    {
        public double get_total { get; }
        private double total_;

        public double Accumulator { get; private set; }

        public Calculator()
        {
            total_ = 0;
        }
        public double Add(double a, double b)
        {
            Accumulator =  a + b;
            return Accumulator; 
        }

        public double Subtract(double a, double b)
        {

            return Accumulator = a - b;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }
    }
}
