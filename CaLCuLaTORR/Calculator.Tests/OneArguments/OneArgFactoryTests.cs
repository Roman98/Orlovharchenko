using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class OneArgFactoryTests
    {
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Factorial", typeof(Factorial))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Cotangens", typeof(Cotangens))]
        [TestCase("Inverseof", typeof(InverseOf))]
        [TestCase("Lg", typeof(Lg))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Radical", typeof(Radical))]
        [TestCase("Radical3", typeof(Radical3))]
        [TestCase("Tangens", typeof(Tangens))]
        public void TwoArgFactoryTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}