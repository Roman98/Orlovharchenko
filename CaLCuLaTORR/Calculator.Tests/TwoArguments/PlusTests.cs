using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
[TestFixture]
    public class PlusTests
    {
    [TestCase(6, 2, 8)]
    [TestCase(-2, 4, 2)]
    public void PlusTest(double firstvalue,double secondvalue, double expected)
    {
        ITwoArgCalculator calculator = new Plus();
        double result = calculator.Calculate(firstvalue, secondvalue);
        Assert.AreEqual(expected,result);
    }

    }
}