using System;

namespace Calculator
{
    public class Inverseof:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return 1/(firstvalue);
        }
        
    }
}