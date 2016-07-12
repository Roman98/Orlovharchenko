using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class CotangensTests
    {
        [TestCase(1, 0.6420)]
        [TestCase(90, -0.5012)]
        public void CotangensTest(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Cotangens();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}