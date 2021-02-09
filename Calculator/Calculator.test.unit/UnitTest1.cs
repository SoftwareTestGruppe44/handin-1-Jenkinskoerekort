using System;
using NUnit.Framework;

namespace Calculator.test.unit
{
    public class CalculatorTests
    {
        private TheCalculator _testCalculator;
        [SetUp]
        public void Setup()
        {
            _testCalculator = new TheCalculator();
        }

        [TestCase(100, 200, 300)]
        [TestCase(200, 100, 300)]
        [TestCase(100, -50, 50)]
        [TestCase(-50, 100, 50)]
        [TestCase(15.8, 14, 29.8)]
        [TestCase(14,15.8,29.8)]
        [TestCase(10.75, -5.5, 5.25)]
        [TestCase(-10.75, 5.5, -5.25)]
        [TestCase(-45.5, -54.5, -100)]
        [TestCase(-54.5,-45.5,-100)]
        [Category("Add")]
        public void Add_positiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Add(a, b), result);
        }

        [Category("Subtract")]
        [TestCase(300, 100, 200)]
        [TestCase(100, 300, -200)]
        [TestCase(30, -10, 40)]
        [TestCase(-30, -20, -10)]
        [TestCase(30.4, 20.2, 10.2)]
        [TestCase(3.5, -1.2, 4.7)]
        [TestCase(-30.5, -25, -5.5)]
        [TestCase(-20.8, -15.3, -5.5)]
        public void Subtract_PositiveAndNegative_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Subtract(a, b), result);
        }

        [Category("Multiply")]
        [TestCase(5, 10, 50)]
        [TestCase(10, 5, 50)]
        [TestCase(5.5,10.5,57.75)]
        [TestCase(10.5, 5.5, 57.75)]
        [TestCase(-5, -4, 20)]
        [TestCase(-4, -5, 20)]
        [TestCase(-5.5, -10.5, 57.75)]
        [TestCase(-10.5, -5.5, 57.75)]
        [TestCase(10, -10, -100)]
        [TestCase(-10,10,-100)]
        [TestCase(10, -10.5, -105)]
        [TestCase(-10.5, 10, -105)]
        [TestCase(10.5, -5, -52.5)]
        [TestCase(-5, 10.5, -52.5)]
        public void Multiply_PositiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Multiply(a, b), result);
        }
        
        [TestCase(5,2,25)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, 3, -8)]
        [TestCase(2.5, 3, 15.625)]
        [TestCase(-1, -3, -1)]
        [TestCase(0.5, 2, 0.25)]
        [TestCase(-0.5, 2, 0.25)]
        [Category("Power")]
        public void Power_PositiveAndNegativeNumbers_ResultIsRight(double x, double exp, double result)
        {
            Assert.AreEqual(_testCalculator.Power(x, exp), result);
        }

        [TestCase(5,5)]
        [TestCase(-5,-5)]
        [TestCase(5.5,5.5)]
        [TestCase(-5.5,-5.5)]
        [Category("Accumulator - set and get")]
        public void Accumulator_SetAndGet_ResultIsRight(double a, double result)
        {
            _testCalculator.Accumulator = a;
            Assert.AreEqual(_testCalculator.Accumulator,result);
        }

        [TestCase(5, 5,10)]
        [TestCase(5, -5, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5, -5,-10)]
        [TestCase(5.5, 5.5,11)]
        [TestCase(7, -5.5, 1.5)]
        [TestCase(-5.5, 7, 1.5)]
        [TestCase(-5.5, -5.5,-11)]
        [Category("Accumulator - Add")]
        public void Accumulator_AddTwoNumberAndGet_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Add(a, b);
            Assert.AreEqual(_testCalculator.Accumulator, result);
        }

        [TestCase(300, 100, 200)]
        [TestCase(100, 300, -200)]
        [TestCase(30, -10, 40)]
        [TestCase(-30, -20, -10)]
        [TestCase(30.4, 20.2, 10.2)]
        [TestCase(3.5, -1.2, 4.7)]
        [TestCase(-30.5, -25, -5.5)]
        [TestCase(-20.8, -15.3, -5.5)]
        [Category("Accumulator - Subtract")]
        public void Accumulator_SubtractTwoNumberAndGet_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Subtract(a, b);
            Assert.AreEqual(_testCalculator.Accumulator, result);
        }

        [TestCase(5, 10, 50)]
        [TestCase(10, 5, 50)]
        [TestCase(5.5, 10.5, 57.75)]
        [TestCase(10.5, 5.5, 57.75)]
        [TestCase(-5, -4, 20)]
        [TestCase(-4, -5, 20)]
        [TestCase(-5.5, -10.5, 57.75)]
        [TestCase(-10.5, -5.5, 57.75)]
        [TestCase(10, -10, -100)]
        [TestCase(-10, 10, -100)]
        [TestCase(10, -10.5, -105)]
        [TestCase(-10.5, 10, -105)]
        [TestCase(10.5, -5, -52.5)]
        [TestCase(-5, 10.5, -52.5)]
        [Category("Accumulator - Multiply")]
        public void Accumulator_MultiplyTwoNumberAndGet_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Multiply(a, b);
            Assert.AreEqual(_testCalculator.Accumulator, result);
        }

        [TestCase(5, 2, 25)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, 3, -8)]
        [TestCase(2.5, 3, 15.625)]
        [TestCase(-1, -3, -1)]
        [TestCase(0.5, 2, 0.25)]
        [TestCase(-0.5, 2, 0.25)]
        [Category("Accumulator - Power")]
        public void Accumulator_PowerTwoNumberAndGet_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Power(a, b);
            Assert.AreEqual(_testCalculator.Accumulator, result);
        }

        [TestCase(5, 5, 10)]
        [TestCase(5, -5, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5, -5, -10)]
        [TestCase(5.5, 5.5, 11)]
        [TestCase(7, -5.5, 1.5)]
        [TestCase(-5.5, 7, 1.5)]
        [TestCase(-5.5, -5.5, -11)]
        [Category("Overload - Add")]
        public void AddOverload_PositiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Accumulator = a;
            Assert.AreEqual(_testCalculator.Add(b), result);
        }

        [TestCase(300, 100, 200)]
        [TestCase(100, 300, -200)]
        [TestCase(30, -10, 40)]
        [TestCase(-30, -20, -10)]
        [TestCase(30.4, 20.2, 10.2)]
        [TestCase(3.5, -1.2, 4.7)]
        [TestCase(-30.5, -25, -5.5)]
        [TestCase(-20.8, -15.3, -5.5)]
        [Category("Overload - Subtract")]
        public void SubtractOverload_PositiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Accumulator = a;
            Assert.AreEqual(_testCalculator.Subtract(b), result);
        }
        [TestCase(10, 5, 2)]
        [TestCase(5, 10, 0.5)]
        [TestCase(-10, 5, -2)]
        [TestCase(5, -10, -0.5)]
        [TestCase(4.8, 4, 1.2)]
        [TestCase(4, 4.8, 0.8)]
        [TestCase(-5, -10, 0.5)]
        [TestCase(-10, -5, 2)]
        [Category("Divide")]
        public void Divide_PositiveAndNegativeNumbers_ResultIsRight(double dividend, double divisor, double result)
        {
            Assert.AreEqual(Math.Round(_testCalculator.Divide(dividend, divisor), 1), Math.Round(result, 1));
        }

        [TestCase(10, 0)]
        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        [Category("Divide, Exception test")]
        public void Divide_DivideWithZero_ResultIsExceptionThrown(double dividend, double divisor)
        {
            Assert.That(() => _testCalculator.Divide(dividend, divisor), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(5, 10, 50)]
        [TestCase(10, 5, 50)]
        [TestCase(5.5, 10.5, 57.75)]
        [TestCase(10.5, 5.5, 57.75)]
        [TestCase(-5, -4, 20)]
        [TestCase(-4, -5, 20)]
        [TestCase(-5.5, -10.5, 57.75)]
        [TestCase(-10.5, -5.5, 57.75)]
        [TestCase(10, -10, -100)]
        [TestCase(-10, 10, -100)]
        [TestCase(10, -10.5, -105)]
        [TestCase(-10.5, 10, -105)]
        [TestCase(10.5, -5, -52.5)]
        [TestCase(-5, 10.5, -52.5)]
        [Category("Overload - Multiply")]
        public void Overload_MultiplyTwoNumberAndGet_ResultIsRight(double a, double b, double result)
        {
            _testCalculator.Accumulator = a;
            Assert.AreEqual(_testCalculator.Multiply(b), result);
        }

        [TestCase(5, 2, 25)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, 3, -8)]
        [TestCase(2.5, 3, 15.625)]
        [TestCase(-1, -3, -1)]
        [TestCase(0.5, 2, 0.25)]
        [TestCase(-0.5, 2, 0.25)]
        [Category("Overload - Power")]
        public void Overload_PowerTwoNumberAndGet_ResultIsRight(double a, double b,  double result)
        {
            _testCalculator.Accumulator = a;
            Assert.AreEqual(_testCalculator.Power(b), result);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(-10)]
        [TestCase(0)]
        [Category("Clear")]
        public void Clear_SetAccumulatorAndClear_AccumulatorIsZero(double acc)
        {
            //Arrange
            _testCalculator.Accumulator = acc;

            //Act
            _testCalculator.Clear();

            //Assert
            Assert.AreEqual(_testCalculator.Accumulator, 0);
        }
    }
}