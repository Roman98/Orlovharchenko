
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class UmnojenieTests
    {
        [Test]
        public void UmnojenieTest()
        {
            ITwoArgCalculator calculator = new Multiplication();
            double result = calculator.Calculate(12, 5);
            Assert.AreEqual(60, result);
        }
    }
}