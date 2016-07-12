namespace Calculator
{
    public class Plus : ITwoArgCalculator
    {
        public double Calculator(double firstvalue, double secondvalue)
        {
            return firstvalue + secondvalue;
        }
    }
}