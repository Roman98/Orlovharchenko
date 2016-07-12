namespace Calculator
{
    public class Minus : ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue - secondvalue;
        }
    
    }
}
