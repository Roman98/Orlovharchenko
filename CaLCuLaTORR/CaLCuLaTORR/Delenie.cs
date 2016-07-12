namespace Calculator
{
    public class Delenie : ITwoArgCalculator
    {
        public double Calculator(double firstvalue, double secondvalue)
        {
            return firstvalue / secondvalue;
        }
    
    }
}