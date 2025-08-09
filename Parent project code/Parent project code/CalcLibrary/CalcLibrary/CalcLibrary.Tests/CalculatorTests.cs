using CalcLibrary;
using NUnit.Framework;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new SimpleCalculator();
        }

        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        public void Addition_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 3, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -1, -1)]
        public void Subtraction_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            var result = _calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, 3, 6)]
        [TestCase(5, 0, 0)]
        [TestCase(-2, -2, 4)]
        public void Multiplication_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            var result = _calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Division_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            var result = _calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }
    }
}
