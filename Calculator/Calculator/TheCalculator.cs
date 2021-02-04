using System;

namespace Calculator
{
    public class TheCalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}