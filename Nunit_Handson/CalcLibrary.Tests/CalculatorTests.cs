using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expected)
        {
            var result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
