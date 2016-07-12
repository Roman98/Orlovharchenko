using System;

namespace Calculator.OneArguments
{
    public class Cosinus:IOneArgCalculator
    {       
            public double Calculate(double firstvalue)
            {
                return Math.Cos(firstvalue);
            }
        
    }
}