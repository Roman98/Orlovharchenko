﻿namespace Calculator.TwoArguments
{
    public class Mod:ITwoArgCalculator
    {
        public double Calculate(double firstvalue, double secondvalue)
        {
            return firstvalue % secondvalue;
        }
    }
}