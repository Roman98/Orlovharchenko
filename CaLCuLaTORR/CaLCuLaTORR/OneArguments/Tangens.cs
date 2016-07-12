using System;

namespace Calculator
{
    public class Tangens:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Tan(firstvalue);
        }
        
    }
}