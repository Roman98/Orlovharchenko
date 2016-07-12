using System;

namespace Calculator.OneArguments
{
    public class Radical:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Sqrt(firstvalue);
        }
    }
}