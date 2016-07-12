namespace Calculator.TwoArguments
{
    public class Multiplication:ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue * secondvalue;
        }
    
    }
}