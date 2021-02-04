using Calculator;
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
        [TestCase(10.75, -5.5, 5.25)]
        [TestCase(-10.75, 5.5, -5.25)]
        [Category("Add")]
        public void Add_positiveAndNegativeNumbers_ResultIsRight(double a, double b, double result)
        {
            Assert.AreEqual(_testCalculator.Add(a, b), result);
        }
        
        [Test]
        [Category("SubTract")]
        public void Subtract300And100_200()
        {
            Assert.AreEqual(_testCalculator.Subtract(300, 100), 200);
        }

        [Test]
        [Category("SubTract")]
        public void Subtract30AndNegative10_40()
        {
            Assert.AreEqual(_testCalculator.Subtract(30, -10), 40);
        }
        [Test]
        [Category("SubTract")]
        public void SubtractNegative30AndNegative20_negative10()
        {
            Assert.AreEqual(_testCalculator.Subtract(-30, -20), -10);
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
        public void MultiplyNegative5andNegative4_20()
        {
            Assert.AreEqual(_testCalculator.Multiply(-5, -4), 20);
        }

        [Test]
        [Category("Multiply")]
        public void Multiply10andNegative10_Negative100()
        {
            Assert.AreEqual(_testCalculator.Multiply(10, -10), -100);
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