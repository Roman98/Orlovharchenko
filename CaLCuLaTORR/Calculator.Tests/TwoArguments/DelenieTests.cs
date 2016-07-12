using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DelenieTests
    {
         [Test]
        public void Delenietests()
        {
            ITwoArgCalculator calculator = new Division();
            double result = calculator.Calculate(12, 3);
            Assert.AreEqual(4, result);
        }
    }
}