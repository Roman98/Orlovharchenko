namespace Calculator.OneArguments
{
    public class InverseOf:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return 1/(firstvalue);
        }
        
    }
}