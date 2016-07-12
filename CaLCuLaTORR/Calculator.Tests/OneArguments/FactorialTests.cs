using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class FactorialTests
    {
        [TestCase(5, 120)]
        [TestCase(0, 1)]
        public void CotangensTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Factorial();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result);
        }
    }
}