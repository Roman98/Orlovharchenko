using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class LgTests
    {
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        public void LgTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Lg();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result);
        }
        [TestCase]
        public void NegativeFirstNumberTest()
        {
            IOneArgCalculator calculator = new Lg();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));
        }
    }
}