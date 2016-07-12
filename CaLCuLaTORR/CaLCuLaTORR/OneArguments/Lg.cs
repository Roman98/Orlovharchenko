using System;

namespace Calculator.OneArguments
{
    public class Lg:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Log10(firstvalue);
        }
    }
}