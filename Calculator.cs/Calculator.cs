using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    public class Calculator : ICalculator
    {
        public double Accumulator { get; private set; }
        //private double total_;
        
        //private List<double> _res = new List<double>();


        public Calculator()
        {
            Accumulator = 1;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public Calculator Add_1(double addend)
        {
            Accumulator += addend;
            
            return this;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public Calculator Subract_1(double subtractor)
        {
            Accumulator -= subtractor;

            return this;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public Calculator Multiply(double multiplier)
        {
            Accumulator *= multiplier;

            return this;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public Calculator Power_1(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);

            return this;
        }

        public Calculator Divide(double division)
        {
            Accumulator /= division;

            return this;
        }


    }
}
