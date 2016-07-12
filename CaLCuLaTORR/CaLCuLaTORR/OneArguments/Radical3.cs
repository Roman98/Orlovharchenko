using System;

namespace Calculator
{
    public class Radical3:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Pow(firstvalue,1/3f);
        }
    }
}