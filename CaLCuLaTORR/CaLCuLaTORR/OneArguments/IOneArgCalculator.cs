namespace Calculator.OneArguments
{
    public interface IOneArgCalculator
    {
        /// <summary>
        /// This is interface for one argument operations.
        /// </summary>
        /// <param name="firstvalue"></param>
        /// <returns></returns>
        double Calculate(double firstvalue);
    }
}