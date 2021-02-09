using System;

namespace Calculator
{
    public class TheCalculator
    {
        public double Accumulator { get; set; } = 0;

        public double Add(double a, double b)
        {
            var result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            var result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new ArgumentOutOfRangeException("divisor = 0 is not allowed");
            return dividend / divisor;
        }

        public double Power(double exponent)
        {
            var result = Power(Accumulator, exponent);
            return result;
        }
    }
}