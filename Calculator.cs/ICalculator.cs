using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    interface ICalculator
    {
        double Divide(double dividend, double divisor);
        double Add(double a, double b);
        Calculator Add(double addend);
        double Subtract(double a, double b);
        Calculator Subtract(double subtractor);
        double Multiply(double a, double b);
        Calculator Multiply(double multiplier);
        double Power(double x, double exp);
        Calculator Power(double exponent);

        Calculator Divide(double division);

        void clear();

        void divideException();
       
    }
}
