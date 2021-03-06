﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        [TestCase(10, 2, 5)]
        [TestCase(10,-2,-5)]
        [TestCase(-10,2,-5)]
        [TestCase(-10, -2, 5)]
        public void divide_2parameters(double dividend, double divisor, double result)
        {
            Assert.That(uut.Divide(dividend,divisor), Is.EqualTo(uut.Accumulator));
        }

        [Test]
        public void addNumbers_twoNumbers_return1()
        {
            //arrange
            //Act
            //Assert
            Assert.That(uut.Add(1, 0), Is.EqualTo(1));
        }

        [Test]
        public void addNumbers_twoNumbers_secondMinusFirstPlus_return1()
        {

            Assert.That(uut.Add(2, -1), Is.EqualTo(1));
        }

        [Test]
        public void addNumbers_twoNumbers_FirstMinusSecondPlus_return1()
        {

            Assert.That(uut.Add(-1, 2), Is.EqualTo(1));
        }

        [Test]
        public void subractNumbers_twoNumbers_return1()
        {
            Assert.That(uut.Subtract(2, 1), Is.EqualTo(1));
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
            Assert.That(uut.Multiply(1, 1), Is.EqualTo(1));
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
            Assert.That(uut.Add(-1, -1), Is.EqualTo(-2));
        }

        /* addition */
        [Test]
        public void add1_bothPositive_return2()
        {
            Assert.That(uut.Add(1).Add(1).Accumulator, Is.EqualTo(2));
        }

        [Test]
        public void add1_Negative_positive_return0()
        {
            Assert.That(uut.Add(-1).Add(1).Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void add1_positive_negative_return0()
        {
            Assert.That(uut.Add(1).Add(-1).Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void add1_negative_negative_returnNegative2()
        {
            Assert.That(uut.Add(-1).Add(-1).Accumulator, Is.EqualTo(-2));
        }

        /* subtraction*/
        [Test]
        public void sub1_bothPositive_returnNegative4()
        {
            Assert.That(uut.Subtract(2).Subtract(2).Accumulator, Is.EqualTo(-4));
        }

        [Test]
        public void sub1_Negative_positive_returnNegative0()
        {
            Assert.That(uut.Subtract(-1).Subtract(1).Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void sub1_positive_negative_return0()
        {
            Assert.That(uut.Subtract(1).Subtract(-1).Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void sub1_negative_negative_return2()
        {
            Assert.That(uut.Subtract(-1).Subtract(-1).Accumulator, Is.EqualTo(2));
        }

        /* Multiply*/
        [Test]
        public void mul1_bothPositive_return8()
        {
            Assert.That(uut.Add(2).Multiply(2).Multiply(2).Accumulator, Is.EqualTo(8));
        }

        [Test]
        public void mul1_Negative_positive_returnNegative8()
        {
            Assert.That(uut.Add(2).Multiply(-2).Multiply(2).Accumulator, Is.EqualTo(-8));
        }

        [Test]
        public void mul1_positive_negative_returnNegative8()
        {
            Assert.That(uut.Add(2).Multiply(2).Multiply(-2).Accumulator, Is.EqualTo(-8));
        }

        [Test]
        public void mul1_negative_negative_return8()
        {
            Assert.That(uut.Add(2).Multiply(-2).Multiply(-2).Accumulator, Is.EqualTo(8));
        }

        /* power*/
        [Test]
        public void pow1_bothPositive_return16()
        {
            Assert.That(uut.Add(2).Power(2).Power(2).Accumulator, Is.EqualTo(16));
        }

        [Test]
        public void pow1_Negative_positive_return00625()
        {
            Assert.That(uut.Add(2).Power(-2).Power(2).Accumulator, Is.EqualTo(0.0625));
        }

        [Test]
        public void pow1_positive_negative_return00625()
        {
            Assert.That(uut.Add(2).Power(2).Power(-2).Accumulator, Is.EqualTo(0.0625));
        }

        [Test]
        public void pow1_negative_negative_return16()
        {
            Assert.That(uut.Add(2).Power(-2).Power(-2).Accumulator, Is.EqualTo(16));
        }

        [Test]
        public void pow_negativeX()
        {
            Assert.That(uut.Power(-2, 3), Is.EqualTo(-8));
        }

        [TestCase(-2,-2,0.25)]
        [TestCase(-4,5, -1024)]
        [TestCase(5, -4, 0.0016)]
        [TestCase(-5, -4, 0.0016)]
        //[TestCase(-5, -4, 10)] failed test
        public void pow_ExpChar(double a,double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        /* division*/
        [Test]
        public void div1_Positive_return1()
        {
            Assert.That(uut.Add(2).Divide(2).Divide(1).Accumulator, Is.EqualTo(1));
        }

        [Test]
        public void div1_Negative_returnNegative5()
        {
            Assert.That(uut.Add(10).Divide(-2).Accumulator, Is.EqualTo(-5));
        }


        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0)]
        public void accumulatorAdd(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(uut.Accumulator));

        }

        /*[TestCase(2, 2, 1)]
         public void accumulatorDivide(double a, double b, double result)
         {
             Assert.That(uut.Divide(a,b),Is.EqualTo(uut.Accumulator));
         }*/

        [TestCase(2, 3, 6)]
        public void accumulatorMultiply(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(uut.Accumulator));
        }


        [TestCase(6, 2, 3)]
        public void accumulatorSubtract(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(uut.Accumulator));
        }

        [TestCase(3, 2, 9)]
        public void accumulatorPower(double x, double exp, double result)
        {
            Assert.That(uut.Power(x, exp), Is.EqualTo(uut.Accumulator));
        }


        [Test]
        public void ClearTest()
        {
            uut.clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        [Test]
        public void divideException()
        {
            Assert.Throws<DivideByZeroException>(() =>uut.Divide(0));
        }
    }
}
