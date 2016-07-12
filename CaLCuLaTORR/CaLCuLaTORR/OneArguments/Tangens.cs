using System;

namespace Calculator.OneArguments
{
    public class Tangens:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Tan(firstvalue);
        }
        
    }
}