using System;

namespace Calculator
{
    public class Cosinus:IOneArgCalculator
    {       
            public double Calculator(double firstvalue)
            {
                return Math.Cos(firstvalue);
            }
        
    }
}