using NUnit.Framework.Internal;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
[TestFixture]
    public class MinusTests
    {
        [TestCase(6, 2, 4)]
        [TestCase(-2, 4, -6)]
        public void MinusTest(double firstvalue, double secondvalue, double expected)
        {
            ITwoArgCalculator calculator = new Minus();
            double result = calculator.Calculate(firstvalue, secondvalue);
            Assert.AreEqual(expected, result);
        }

    }
}