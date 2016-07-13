using System;

namespace Calculator.TwoArguments
{
    public class Division : ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            if(secondvalue == 0)
            {
	            throw new Exception("Деление на ноль");
            }

            return firstvalue / secondvalue;
        }
    
    }
}