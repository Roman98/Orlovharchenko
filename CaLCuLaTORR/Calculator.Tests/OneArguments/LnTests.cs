using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(14, 2.6390)]
        [TestCase(90, 4.4998)]
        public void LnTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Ln();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}