using System;

namespace Calculator.TwoArguments
{
    public class Involution:ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return Math.Pow (firstvalue, secondvalue);
        }
    
    }
}