using System;

namespace Calculator
{
    public class Factorial : IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            if (firstvalue <= 1)
            {
                return 1;
            }
            return firstvalue * Calculate(firstvalue - 1);
        }

    }
}