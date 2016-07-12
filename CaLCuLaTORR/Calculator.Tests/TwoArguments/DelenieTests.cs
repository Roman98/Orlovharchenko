using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DelenieTests
    {
        [TestCase(6, 2, 3)]
        [TestCase(-2, 4, -0.5)]
        public void DelenieTest(double firstvalue, double secondvalue, double expected)
        {
            ITwoArgCalculator calculator = new Division();
            double result = calculator.Calculate(firstvalue, secondvalue);
            Assert.AreEqual(expected, result);
        }

    }
}