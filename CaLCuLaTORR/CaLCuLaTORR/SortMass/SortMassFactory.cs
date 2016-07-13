using System;

namespace Calculator.SortMass
{
    public static class SortMassFactory
    {
        public static ISortMass CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sort1":
                    return new SortMass1();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}