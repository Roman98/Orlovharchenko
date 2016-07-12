using System;

namespace Calculator.OneArguments
{
    public class Ln:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Log(firstvalue,Math.E);
        }
    }
}