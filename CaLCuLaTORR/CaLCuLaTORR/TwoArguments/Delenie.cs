namespace Calculator.TwoArguments
{
    public class Division : ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue / secondvalue;
        }
    
    }
}