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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}