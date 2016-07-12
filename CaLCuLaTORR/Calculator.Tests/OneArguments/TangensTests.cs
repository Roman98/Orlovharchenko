using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class TangensTests
    {
        [TestCase(1, 1.5574)]
        [TestCase(90, -1.9952)]
        public void TangensTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Tangens();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}