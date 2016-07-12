using NUnit.Framework.Internal;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
[TestFixture]
    public class MinusTests
    {
    [Test]
    public void MinusTest()
    {
        ITwoArgCalculator calculator = new Minus();
        double result = calculator.Calculate(12, 5);
        Assert.AreEqual(7, result);
    }    
    }
}