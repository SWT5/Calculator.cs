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
        public void Add1_firstPositive_SecondPositive_return5()
        {
            Assert.That(uut.Add_1(2).Add_1(2).get_total, Is.EqualTo(5));
        }

        [Test]
        public void Add1_firstNegative_secondPositive_return1()
        {
            Assert.That(uut.Add_1(-2).Add_1(2).get_total, Is.EqualTo(1));
        }

        [Test]
        public void Add1_firstPositive_secondNegative_return1()
        {
            Assert.That(uut.Add_1(2).Add_1(-2).get_total, Is.EqualTo(1));
        }

        [Test]
        public void Add1_firstNegative_secondNegative_returnNegative3()
        {
            Assert.That(uut.Add_1(-2).Add_1(-2).get_total, Is.EqualTo(-3));
        }

        /**         subtraction           **/
        [Test]
        public void sub1_firstPositive_secondPositive_returnNegative8()
        {
            Assert.That(uut.Subract_1(5).Subract_1(4).get_total, Is.EqualTo(-8));
        }

        [Test]
        public void sub1_firstNegative_secondPositive_return2()
        {
            Assert.That(uut.Subract_1(-5).Subract_1(4).get_total, Is.EqualTo(2));
        }

        [Test]
        public void sub1_firstPositive_secondNegative_returnNegative0()
        {
            Assert.That(uut.Subract_1(5).Subract_1(-4).get_total, Is.EqualTo(0));
        }

        [Test]
        public void sub1_firstNegative_secondPositive_return10()
        {
            Assert.That(uut.Subract_1(-5).Subract_1(-4).get_total, Is.EqualTo(10));
        }

        /**         Multiplication           **/
        [Test]
        public void mul1_firstPositive_secondPositive_return4()
        {
            Assert.That(uut.Multiply(2).Multiply(2).get_total,Is.EqualTo(4));
        }
        [Test]
        public void mul1_firstNegative_secondPositive_returnNegative4()
        {
            Assert.That(uut.Multiply(-2).Multiply(2).get_total, Is.EqualTo(-4));
        }
        [Test]
        public void mul1_firstPositive_secondNegative_returnNegative4()
        {
            Assert.That(uut.Multiply(2).Multiply(-2).get_total, Is.EqualTo(-4));
        }
        [Test]
        public void mul1_firstNegative_secondNegative_returnNegative4()
        {
            Assert.That(uut.Multiply(-2).Multiply(-2).get_total, Is.EqualTo(4));
        }

        /**         Division           **/
        [Test]
        public void div_firstPositive_secondPositive_return5()
        {
            Assert.That(uut.Add_1(19).Divide(2).Divide(2).get_total,Is.EqualTo(5));
        }
        [Test]
        public void div_firstNegative_secondPositive_returnNegative5()
        {
            Assert.That(uut.Add_1(19).Divide(-2).Divide(2).get_total, Is.EqualTo(-5));
        }
        [Test]
        public void div_firstPositive_secondNegative_returnNegative5()
        {
            Assert.That(uut.Add_1(19).Divide(2).Divide(-2).get_total, Is.EqualTo(-5));
        }
        [Test]
        public void div_firstNegative_secondNegative_returnNegative5()
        {
            Assert.That(uut.Add_1(19).Divide(-2).Divide(-2).get_total, Is.EqualTo(5));
        }

        /**         Power           **/
        [Test]
        public void pow_firstPositive_secondPositive_return16()
        {
            Assert.That(uut.Add_1(1).Power_1(2).Power_1(2).get_total, Is.EqualTo(16));
        }

        [Test]
        public void pow_firstNegative_secondPositive_return00625()
        {
            Assert.That(uut.Add_1(1).Power_1(-2).Power_1(2).get_total,Is.EqualTo(0.0625));
        }
        [Test]
        public void pow_firstPositive_secondNegative_return00625()
        {
            Assert.That(uut.Add_1(1).Power_1(2).Power_1(-2).get_total, Is.EqualTo(0.0625));
        }
        [Test]
        public void pow_firstNegative_secondNegative_return16()
        {
            Assert.That(uut.Add_1(1).Power_1(-2).Power_1(-2).get_total, Is.EqualTo(16));
        }
    }
}
