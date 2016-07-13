using System;

namespace Calculator.TwoArguments
{
    public static class TwoArgFactory
    {
        /// <summary>
        /// If you see this, i tell you this is a factory for two arguments.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public static ITwoArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":                   
                    return new Plus();
                case "minus":                   
                    return new Minus();
                case "umnojenie":                    
                    return new Multiplication();
                case "delenie":
                    return new Division();
                case "Mod":
                    return new Mod();
                case"Involution":
                    return new Involution();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}