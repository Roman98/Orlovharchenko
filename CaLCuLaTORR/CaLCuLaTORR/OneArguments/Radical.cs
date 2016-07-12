using System;

namespace Calculator
{
    public class Radical:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Sqrt(firstvalue);
        }
    }
}