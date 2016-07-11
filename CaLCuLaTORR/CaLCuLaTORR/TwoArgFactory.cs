using System;
using System.Windows.Forms;

namespace CaLCuLaTORR
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}