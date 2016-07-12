using System;

namespace Calculator
{
    public class Cotangens:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Cos(firstvalue)/Math.Sin(firstvalue);
        }
        
    }
}