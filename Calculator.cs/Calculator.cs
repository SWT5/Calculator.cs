using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    public class Calculator : ICalculator
    {
        public double get_total { get; private set; }
        //private double total_;
        
        //private List<double> _res = new List<double>();


        public Calculator()
        {
           get_total = 0;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public Calculator Add_1(double addend)
        {
            get_total += addend;
            
            return this;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public Calculator Subract_1(double subtractor)
        {
            get_total -= subtractor;
            return this;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public object Add_1(object v)
        {
            throw new NotImplementedException();
        }
    }
}
