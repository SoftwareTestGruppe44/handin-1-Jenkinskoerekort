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

        public double Subtract(double subtractor)
        {
            var result = Subtract(Accumulator,subtractor);
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double multiplier)
        {
            var result = Multiply(Accumulator, multiplier);
            return result;
        }

        public double Power(double x, double exp)
        {
            var result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Power(double exponent)
        {
            var result = Power(Accumulator, exponent);
            return result;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new ArgumentOutOfRangeException("Divisor = 0 is not allowed");
            var result = dividend / divisor;
            Accumulator = result;
            return result;
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}