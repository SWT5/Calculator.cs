using System;
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


        /***    To Handin (add, subtract, multiply, Divide, Power)   ***/
        
        /**         Addition            **/
        [Test]
        public void Add1_firstPositive_SecondPositive_return2()
        {
            Assert.That(uut.Add_1(2).Add_1(2).get_total, Is.EqualTo(4));
        }

        [Test]
        public void Add1_firstNegative_secondPositive_return0()
        {
            Assert.That(uut.Add_1(-2).Add_1(2).get_total, Is.EqualTo(0));
        }

        [Test]
        public void Add1_firstPositive_secondNegative_return0()
        {
            Assert.That(uut.Add_1(2).Add_1(-2).get_total, Is.EqualTo(0));
        }

        [Test]
        public void Add1_firstNegative_secondNegative_returnNegative4()
        {
            Assert.That(uut.Add_1(-2).Add_1(-2).get_total, Is.EqualTo(-4));
        }

        /**         subtraction           **/
        [Test]
        public void sub1_firstPositive_secondPositive_return1()
        {
            Assert.That(uut.Subract_1(5).Subract_1(4).get_total, Is.EqualTo(-9));
        }

        [Test]
        public void sub1_firstNegative_secondPositive_return1()
        {
            Assert.That(uut.Subract_1(-5).Subract_1(4).get_total, Is.EqualTo(1));
        }

        [Test]
        public void sub1_firstPositive_secondNegative_returnNegative1()
        {
            Assert.That(uut.Subract_1(5).Subract_1(-4).get_total, Is.EqualTo(-1));
        }

        [Test]
        public void sub1_firstNegative_secondPositive_return9()
        {
            Assert.That(uut.Subract_1(-5).Subract_1(-4).get_total, Is.EqualTo(9));
        }

        /**         Multiplication           **/
        [Test]
        public void mul1_firstPositive_secondPositive_return4()
        {
            Assert.That(uut.Add_1(1).Multiply(2).Multiply(2).get_total,Is.EqualTo(4));
        }
        [Test]
        public void mul1_firstNegative_secondPositive_returnNegative4()
        {
            Assert.That(uut.Add_1(1).Multiply(-2).Multiply(2).get_total, Is.EqualTo(-4));
        }
        [Test]
        public void mul1_firstPositive_secondNegative_returnNegative4()
        {
            Assert.That(uut.Add_1(1).Multiply(2).Multiply(-2).get_total, Is.EqualTo(-4));
        }
        [Test]
        public void mul1_firstNegative_secondNegative_returnNegative4()
        {
            Assert.That(uut.Add_1(1).Multiply(-2).Multiply(-2).get_total, Is.EqualTo(4));
        }
    }
}
