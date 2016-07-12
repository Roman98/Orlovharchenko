using System;
using System.Windows.Forms;

namespace Calculator
{
    public static class TwoArgFactory
    {
        public static ITwoArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":                   
                    return new Plus();
                case "minus":                   
                    return new Minus();
                case "umnojenie":                    
                    return new Umnojenie();
                case "delenie":
                    return new Delenie();
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