using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(1, 0.5403)]
        [TestCase(90, -0.4480)]
        public void CosinusTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Cosinus();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result , 0.0001);
        }
    }
}