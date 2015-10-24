using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdvanceCalculator;

namespace AdvanceCalculatorTests_NUnit
{
    [TestFixture]

    public class AdvanceCalculatorTests
    {
        private int a, b;

        [Test]
        public void operatorPlusTest()
        {
            Calculator calculator = new Calculator();
            // Input Parameter
            a = 3;
            b = 4;
            int expectedResult = 7;
            Assert.AreEqual(expectedResult, calculator.operatorPlus(a, b), "Expected Result is 7 but Actual Result is {0}", expectedResult);
        }

        [Test]
        public void operatorMinusTest()
        {
            Calculator calculator = new Calculator();
            // Input Parameter
            a = 5;
            b = 4;
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, calculator.operatorMinus(a, b), "Expected Result is 1 but Actual Result is {0}", expectedResult);
        }

        [Test]
        public void operatorMultiplyTest()
        {
            Calculator calculator = new Calculator();
            // Input Parameter
            a = 10;
            b = 5;
            int expectedResult = 50;
            Assert.AreEqual(expectedResult, calculator.operatorMultiply(a, b), "Expected Result is 50 but Actual Result is {0}", expectedResult);
        }

        [Test]
        public void operatorDivideTest()
        {
            Calculator calculator = new Calculator();
            // Input Parameter
            a = 10;
            b = 5;
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, calculator.operatorDivide(a, b), "Expected Result is 2 but Actual Result is {0}", expectedResult);
        }

        [Test]
        public void operatorSquareTest()
        {
            Calculator calculator = new Calculator();
            // Input Parameter
            a = 5;
            b = 3;
            int expectedResult = 125;
            Assert.AreEqual(expectedResult, calculator.operatorSquare(a, b), "Expected Result is 125 but Actual Result is {0}", expectedResult);
        }
    }
}
