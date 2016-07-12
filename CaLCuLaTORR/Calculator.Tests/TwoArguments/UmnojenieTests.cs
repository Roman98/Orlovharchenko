
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class UmnojenieTests
    {
        [TestCase(6, 2, 12)]
        [TestCase(-2, 4, -8)]
        public void UmnojenieTest(double firstvalue, double secondvalue, double expected)
        {
            ITwoArgCalculator calculator = new Multiplication();
            double result = calculator.Calculate(firstvalue, secondvalue);
            Assert.AreEqual(expected, result);
        }

    }
}