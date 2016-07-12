using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class InverseofTests
    {
        [TestCase(2, 0.5)]
        [TestCase(0.25, 4)]
        public void InverseofTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new InverseOf();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result);
        }
    }
}