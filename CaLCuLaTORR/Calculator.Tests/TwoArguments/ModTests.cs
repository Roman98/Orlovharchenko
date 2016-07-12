using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class ModTests
    {
        [TestCase(6, 2, 0)]
        [TestCase(8, 3, 2)]
        public void ModTest(double firstvalue, double secondvalue, double expected)
        {
            ITwoArgCalculator calculator = new Mod();
            double result = calculator.Calculate(firstvalue, secondvalue);
            Assert.AreEqual(expected, result);
        }
    }
}