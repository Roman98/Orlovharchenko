using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgFactoryTests
    {
        [TestCase("plus", typeof(Plus))]
        [TestCase("Mod", typeof(Mod))]
        [TestCase("delenie", typeof(Division))]
        [TestCase("umnojenie", typeof(Multiplication))]
        [TestCase("Involution", typeof(Involution))]
        [TestCase("minus", typeof(Minus))]
        public void TwoArgFactoryTest(string name, Type type)
        {
            var calculator = TwoArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}