using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    class AccumulatorException : Exception
    {
        public double Accumulator { get; private set; }


    }
}
