using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class Radical3Tests
    {
        [TestCase(8, 2)]
        [TestCase(27, 3)]
        public void Radical3Test(double firstvalue, double expected)
        {
            IOneArgCalculator calculator = new Radical3();
            double result = calculator.Calculate(firstvalue);
            Assert.AreEqual(expected, result);
        }
    }
}