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
        double Add(double a, double b);
        Calculator Add_1(double addend);
        double Subtract(double a, double b);
        Calculator Subract_1(double subtractor);
        double Multiply(double a, double b);
        Calculator Multiply(double multiplier);
        double Power(double x, double exp);
    }
}
