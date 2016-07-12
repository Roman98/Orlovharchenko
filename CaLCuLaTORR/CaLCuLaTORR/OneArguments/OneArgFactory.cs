using System;

namespace Calculator
{
    public static class OneArgFactory
    {
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
                    return new Inverseof();
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