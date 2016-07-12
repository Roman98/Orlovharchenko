using System;

namespace Calculator.OneArguments
{
    public class Sinus:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Sin(firstvalue);            
        }
    
    }
}