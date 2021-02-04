using Calculator;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProgram
{
    public class Tests
    {
        private TheCalculator TestCalculator;
        [SetUp]
        public void Setup()
        {
            TestCalculator = new TheCalculator();
        }
        [Test]
        [Category("Add")]
        public void Add100and300_400()
        {
            Assert.AreEqual(TestCalculator.Add(100, 300), 400);
        }

        [Test]
        [Category("Add")]
        public void AddNegative20AndNegative30_Negative50()
        {
            Assert.AreEqual(TestCalculator.Add(-20, -30), -50);
        }

        [Test]
        [Category("Add")]
        public void Add40AndNegative20()
        {
            Assert.AreEqual(TestCalculator.Add(40, -20), 20);
        }
        [Test]
        [Category("Add")]
        public void Add30Dot5And50Dot3_80Dot8()
        {
            Assert.AreEqual(TestCalculator.Add(30.5, 50.3), 80.8);
        }
        [Test]
        [Category("SubTract")]
        public void Subtract300And100_200()
        {
            Assert.AreEqual(TestCalculator.Subtract(300, 100), 200);
        }

        [Test]
        [Category("SubTract")]
        public void Subtract30AndNegative10_40()
        {
            Assert.AreEqual(TestCalculator.Subtract(30, -10), 40);
        }
        [Test]
        [Category("SubTract")]
        public void SubtractNegative30AndNegative20_negative10()
        {
            Assert.AreEqual(TestCalculator.Subtract(-30, -20), -10);
        }

        [Test]
        [Category("SubTract")]
        public void Subtract30Dot4and20Dot2_10Dot2()
        {
            Assert.AreEqual(TestCalculator.Subtract(30.4, 20.2), 10.2);
        }
        [Test]
        [Category("Multiply")]
        public void Multiply2and5_10()
        {
            Assert.AreEqual(TestCalculator.Multiply(2, 5), 10);
        }

        [Test]
        [Category("Multiply")]
        public void MultiplyNegative5andNegative4_20()
        {
            Assert.AreEqual(TestCalculator.Multiply(-5, -4), 20);
        }

        [Test]
        [Category("Multiply")]
        public void Multiply10andNegative10_Negative100()
        {
            Assert.AreEqual(TestCalculator.Multiply(10, -10), -100);
        }

        [Test]
        [Category("Power")]
        public void Power5Exp2_100()
        {
            Assert.AreEqual(TestCalculator.power(5, 2), 25);
        }

        [Test]
        [Category("Power")]
        public void Power2ExpNegative2_0Dot25()
        {
            Assert.AreEqual(TestCalculator.power(2, -2), 0.25);
        }

        [Test]
        [Category("Power")]
        public void PowerNegative2Exp3_Negative8()
        {
            Assert.AreEqual(TestCalculator.power(-2, 3), -8);
        }

        [Test]
        [Category("Power")]
        public void Power2Dot5Exp3_Negative8()
        {
            Assert.AreEqual(TestCalculator.power(2.5, 3), 15.625);
        }
    }
}