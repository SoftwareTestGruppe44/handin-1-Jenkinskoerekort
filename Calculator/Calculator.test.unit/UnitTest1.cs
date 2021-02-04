using Calculator;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProgram
{
    public class Tests
    {
        private TheCalculator _testCalculator;
        [SetUp]
        public void Setup()
        {
            _testCalculator = new TheCalculator();
        }
        [Test]
        [Category("Add")]
        public void Add100and300_400()
        {
            Assert.AreEqual(_testCalculator.Add(100, 300), 400);
        }

        [Test]
        [Category("Add")]
        public void AddNegative20AndNegative30_Negative50()
        {
            Assert.AreEqual(_testCalculator.Add(-20, -30), -50);
        }

        [Test]
        [Category("Add")]
        public void Add40AndNegative20()
        {
            Assert.AreEqual(_testCalculator.Add(40, -20), 20);
        }
        [Test]
        [Category("Add")]
        public void Add30Dot5And50Dot3_80Dot8()
        {
            Assert.AreEqual(_testCalculator.Add(30.5, 50.3), 80.8);
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

        [TestCase(5,2,25)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, 3, -8)]
        [TestCase(2.5, 3, 15.625)]
        [TestCase(-1, -3, -1)]
        [TestCase(0.5, 2, 0.25)]
        [TestCase(-0.5, 2, -0.25)]
        [Category("Power")]
        public void PowerOfPositivesAndNegatives(double x, double exp, double result)
        {
            Assert.AreEqual(_testCalculator.power(x, exp), result);
        }

    }
}