using System;

namespace Calculator
{
    public class Involution:ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return Math.Pow (firstvalue, secondvalue);
        }
    
    }
}