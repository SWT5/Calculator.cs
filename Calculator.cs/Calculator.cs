using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    public class Calculator : ICalculator
    {

        public double Accumulator { get; private set; }     // accumulator property

        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return Accumulator;
        }
        public Calculator()
        {
            Accumulator = 0;
        }
        public double Add(double a, double b)
        {
            Accumulator =  a + b;
            return Accumulator; 
        }

        public Calculator Add(double addend)
        {
            Accumulator += addend;
            
            return this;
        }

        public double Subtract(double a, double b)
        {

            return Accumulator = a - b;
        }

        public Calculator Subract(double subtractor)
        {
            Accumulator -= subtractor;

            return this;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public Calculator Multiply(double multiplier)
        {
            Accumulator *= multiplier;

            return this;
        }

        public double Power(double x, double exp)
        {
            try
            {
                Accumulator = Math.Pow(x, exp);
            }

            catch (InvalidOleVariantTypeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return Accumulator;
        }

        public Calculator Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);

            return this;
        }

        public Calculator Divide(double division)
        {
            if (division == 0)
            {
                divideException();
            }
            Accumulator /= division;

            return this;
        }
        public void clear()
        {
            Accumulator = 0;
        }

        public void divideException()
        {
            throw new System.DivideByZeroException("Not allowed to divide by zero");
        }
    }
}
