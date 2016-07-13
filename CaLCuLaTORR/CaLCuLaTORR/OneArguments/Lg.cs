using System;

namespace Calculator.OneArguments
{
    public class Lg:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            if (firstvalue < 0)
            {
                throw new Exception("Логарифм из отрицательного числа не существует");
            }
            return Math.Log10(firstvalue);
        }
    }
}