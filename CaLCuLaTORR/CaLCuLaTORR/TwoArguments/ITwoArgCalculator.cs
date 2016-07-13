namespace Calculator.TwoArguments
{
    public interface ITwoArgCalculator
    {
        /// <summary>
        /// If you see this tell you, this is interface for two arguments operations.
        /// </summary>
        /// <param name="firstvalue"></param>
        /// <param name="secondvalue"></param>
        /// <returns></returns>
        double Calculate(double firstvalue, double secondvalue);
    }
}