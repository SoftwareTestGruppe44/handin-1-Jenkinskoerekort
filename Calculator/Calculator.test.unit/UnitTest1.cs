using Calculator;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProgram
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
        [Category("Add")]
        public void Add_positiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Add(a, b), result);
        }

        [TestCase(300, 100, 200)]
        [TestCase(30, -10, 40)]
        [TestCase(-30, -20, -10)]
        [TestCase(30.4, 20.2, 10.2)]
        [TestCase(-30.5, -25, -5.5)]
        [Category("SubTract")]
        public void Subtract_PositiveAndNegative_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Subtract(30, -10), 40);
        }

        [Test]
        [Category("SubTract")]
        public void Subtract30Dot4and20Dot2_10Dot2()
        {
            Assert.AreEqual(_testCalculator.Subtract(30.4, 20.2), 10.2);
        }
        [Test]
        [Category("Multiply")]
        public void Multiply2and5_10()
        {
            Assert.AreEqual(_testCalculator.Multiply(2, 5), 10);
        }

        [Test]
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

        [Test]
        [Category("Power")]
        public void Power5Exp2_100()
        {
            Assert.AreEqual(_testCalculator.power(5, 2), 25);
        }

        [Test]
        [Category("Power")]
        public void Power2ExpNegative2_0Dot25()
        {
            Assert.AreEqual(_testCalculator.power(2, -2), 0.25);
        }

        [Test]
        [Category("Power")]
        public void PowerNegative2Exp3_Negative8()
        {
            Assert.AreEqual(_testCalculator.power(-2, 3), -8);
        }

        [Test]
        [Category("Power")]
        public void Power2Dot5Exp3_Negative8()
        {
            Assert.AreEqual(_testCalculator.power(2.5, 3), 15.625);
        }
    }
}