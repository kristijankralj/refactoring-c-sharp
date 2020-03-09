using System;

namespace SimplifyingConditional
{
    public class ConsolidateConditionalExpression
    {
        public static bool IsFibonnaciNumber(int number)
        {
            if (number == 0)
            {
                return true;
            }
            if (number == 1)
            {
                return true;
            }
            if (number == 2)
            {
                return true;
            }

            double fi = (1 + Math.Sqrt(5)) / 2.0;
            int n = (int)Math.Floor(Math.Log(number * Math.Sqrt(5) + 0.5, fi));

            int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

            return actualFibonacciNumber == number;
        }
    }
}
