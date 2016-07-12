using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class InvolutionTests
    {
        [TestCase(6, 2, 36)]
        [TestCase(-2, 4, 16)]
        public void InvolutionTest(double firstvalue, double secondvalue, double expected)
        {
            ITwoArgCalculator calculator = new Involution();
            double result = calculator.Calculate(firstvalue, secondvalue);
            Assert.AreEqual(expected, result);
        }
    }
}