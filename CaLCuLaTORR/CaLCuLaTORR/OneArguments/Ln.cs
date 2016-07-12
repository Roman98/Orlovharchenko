using System;
using System.ComponentModel;

namespace Calculator
{
    public class Ln:IOneArgCalculator
    {
        public double Calculate(double firstvalue)
        {
            return Math.Log(firstvalue,Math.E);
        }
    }
}