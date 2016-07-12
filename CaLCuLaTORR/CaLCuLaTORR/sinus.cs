using System;
using System.Runtime.InteropServices;

namespace Calculator
{
    public class Sinus:IOneArgCalculator
    {
        public double Calculator(double firstvalue)
        {
            return Math.Sin(firstvalue);            
        }
    
    }
}