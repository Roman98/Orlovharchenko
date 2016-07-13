using System;

namespace Calculator.OneArguments
{
    public class Radical:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            if (firstvalue <  0)
            {
                throw new Exception("Корень из отрицательного числа не существует");
            }
            return Math.Sqrt(firstvalue);
        }
    }
}