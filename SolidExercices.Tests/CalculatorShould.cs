using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASous()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3,3-2,3");
            Check.That(result).IsEqualTo(1);
        }

        [Test]
        public void CalculateAMul()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1*2,3");
            Check.That(result).IsEqualTo(2.3);
        }
        [Test]
        public void CalculateADiv()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1/2");
            Check.That(result).IsEqualTo(0.5);
        }
        [Test]
        public void CalculateMoreOperations()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("12*45/7");
            Check.That(result).IsEqualTo(0.5);
        }
    }
}
