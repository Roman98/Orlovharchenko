namespace Calculator.TwoArguments
{
    public class Plus : ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue + secondvalue;
        }
    }
}