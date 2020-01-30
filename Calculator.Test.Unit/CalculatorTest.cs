﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator.cs.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator.cs.Calculator();
        }

        [Test]
        public void addNumbers_twoNumbers_return1()
        {
            //arrange
            //Act
            //Assert
            Assert.That(uut.Add(1,0), Is.EqualTo(1));
        }
        
        [Test]
        public void addNumbers_twoNumbers_secondMinusFirstPlus_return1()
        {

            Assert.That(uut.Add(2,-1), Is.EqualTo(1));
        }

        [Test]
        public void addNumbers_twoNumbers_FirstMinusSecondPlus_return1()
        {

            Assert.That(uut.Add(-1, 2), Is.EqualTo(1));
        }
        
        [Test]
        public void subractNumbers_twoNumbers_return1()
        {
            Assert.That(uut.Subtract(2,1),Is.EqualTo(1));
        }

        [Test]
        public void subtractNumbers_twoNumbers_FirstMinusSecondPlus_return3()
        {
            Assert.That(uut.Subtract(-2, 1), Is.EqualTo(-3));
        }

        [Test]
        public void subtractNumbers_twoNumbers_secondMinusFirstPlus_return3()
        {
            Assert.That(uut.Subtract(1, -2), Is.EqualTo(3));
        }

        [Test]
        public void multiplyNumbers_twoNumbers_return1()
        {
            Assert.That(uut.Multiply(1,1), Is.EqualTo(1));
        }

        [Test]
        public void multiplyNumbers_twoNumbers_FirstMinusSecondPlus_returnMinus1()
        {
            Assert.That(uut.Multiply(-1, 1), Is.EqualTo(-1));
        }

        [Test]
        public void multiplyNumbers_twoNumbers_secondMinusFirstPlus_returnMinus1()
        {
            Assert.That(uut.Multiply(1, -1), Is.EqualTo(-1));
        }

        [Test]
        public void powerNumbers_twoNumbers_return1()
        {
            Assert.That(uut.Power(1, 1), Is.EqualTo(1));
        }

        [Test]
        public void powerNumbers_twoNumbers_FirstMinusSecondPlus_returnMinus1()
        {
            Assert.That(uut.Power(-1, 1), Is.EqualTo(-1));
        }

        [Test]
        public void powerNumbers_twoNumbers_secondMinusFirstPlus_returnMinus1()
        {
            Assert.That(uut.Power(1, -1), Is.EqualTo(1));
        }

        [Test]
        public void addMinus_returnnegative2()
        {
            Assert.That(uut.Add(-1,-1),Is.EqualTo(-2));
        }




        [TestCase(2,2,4)]
        [TestCase(2,-2,0)]
        public void accumulatorAdd(double a, double b,double result)
        {
            Assert.That(uut.Add(a,b),Is.EqualTo(uut.Accumulator));

        }

       /*[TestCase(2, 2, 1)]
        public void accumulatorDivide(double a, double b, double result)
        {
            Assert.That(uut.Divide(a,b),Is.EqualTo(uut.Accumulator));
        }*/

       [TestCase(2, 3, 6)]
       public void accumulatorMultiply(double a, double b, double result)
       {
           Assert.That(uut.Multiply(a,b),Is.EqualTo(uut.Accumulator));
       }


       [TestCase(6, 2, 3)]
       public void accumulatorSubtract(double a, double b, double result)
       {
           Assert.That(uut.Subtract(a,b),Is.EqualTo(uut.Accumulator));
       }

       [TestCase(3, 2, 9)]
       public void accumulatorPower(double x, double exp, double result)
       {
           Assert.That(uut.Power(x, exp), Is.EqualTo(uut.Accumulator)); 
       }
    }
}
