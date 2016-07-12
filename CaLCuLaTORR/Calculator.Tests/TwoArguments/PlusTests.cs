using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
[TestFixture]
    public class PlusTests
    {
    [Test]
    public void PlusTest()
    {
        ITwoArgCalculator calculator = new Plus();
        double result = calculator.Calculate(4, 5);
        Assert.AreEqual(9,result);
    }

    }
}