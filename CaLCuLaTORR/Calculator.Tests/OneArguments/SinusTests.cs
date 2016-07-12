using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(1, 0.8414)]
        [TestCase(90, 0.8939)]
        public void SinusTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Sinus();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}