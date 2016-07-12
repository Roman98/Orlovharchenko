using System;

namespace Calculator
{
    public class Lg:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Log10(firstvalue);
        }
    }
}