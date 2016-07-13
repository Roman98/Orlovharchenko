using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class RadicalTests
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        public void RadicalTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Radical();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result);
        }
        [TestCase]
        public void NegativeNumberTest()
        {
            IOneArgCalculator calculator = new Radical();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
        }
    }
}