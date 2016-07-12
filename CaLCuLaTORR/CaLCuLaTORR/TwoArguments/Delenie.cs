namespace Calculator
{
    public class Delenie : ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue / secondvalue;
        }
    
    }
}