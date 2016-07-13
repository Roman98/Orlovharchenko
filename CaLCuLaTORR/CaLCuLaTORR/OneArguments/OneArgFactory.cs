using System;

namespace Calculator.OneArguments
{
    public static class OneArgFactory
    {
        /// <summary>
        /// This is factory for one argument.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static IOneArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sinus":
                    return new Sinus();
                case "Cosinus":
                    return new Cosinus();
                case "Radical":
                    return new Radical();
                case "Lg":
                    return new Lg();
                case "Tangens":
                    return new Tangens();
                case "Cotangens":
                    return new Cotangens();
                case "Inverseof":
                    return new InverseOf();
                case "Factorial":
                    return new Factorial();
                case "Radical3":
                    return new Radical3();
                case "Ln":
                    return new Ln();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}