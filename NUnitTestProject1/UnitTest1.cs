using CurrencyCalc;
using NUnit.Framework;
using Moq;

namespace Tests
{
    public class Tests
    {
        Mock <IRateProvider> mock;
        [SetUp]
        public void Setup()
        {
            mock = new Mock<IRateProvider>();
        }

        [TestCase(0.25, 100)]
        public void Test1(double a, double b)
        {

            mock.Setup(p => p.Pln2EuroRate()).Returns(a);
            var calculator = new CurrencyCalculator(mock.Object);
            var result = calculator.ChangePln2Euro(b);
            Assert.AreEqual(25, result);
            mock.Verify(p => p.Pln2EuroRate(), Times.Once);
        }
        [TestCase(100,0.25)]
        public void Test2(double a, double b)
        {

            mock.Setup(p => p.Euro2PlnRate()).Returns(a);
            var calculator = new CurrencyCalculator(mock.Object);
            var result = calculator.ChangeEuro2Pln(b);
            Assert.AreEqual(25, result);
            mock.Verify(p => p.Euro2PlnRate(), Times.Once);
        }
    }
}