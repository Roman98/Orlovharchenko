using System;

namespace Calculator
{
    public class Cosinus:IOneArgCalculator
    {       
            public double Calculate(double firstvalue)
            {
                return Math.Cos(firstvalue);
            }
        
    }
}