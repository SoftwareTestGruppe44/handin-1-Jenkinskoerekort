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

        public double Add(double addend)
        {
            var result = Add(Accumulator, addend);
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
    }
}