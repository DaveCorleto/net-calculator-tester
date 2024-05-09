using NUnit.Framework;
using net_calculator_tester; 

namespace Calculator_Tester
{
    [TestFixture]
    public class Tests
    {
        private Calculator calculator; 

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator(); 
        }

        [Test]
        public void TestSomma()
        {
            float num1 = 5.5f;
            float num2 = 3.2f;
            float expectedResult = 8.7f;

            
            float result = calculator.Somma(num1, num2);

            
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001f), "La somma non � corretta.");
        }
        [Test]
        public void TestSottrazione()
        {
            float num1 = 82.0f;
            float num2 = 3.5f;
            float expectedResult = 4.5f;

            float result = calculator.Sottrazione(num1, num2);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001f), "La sottrazione non � corretta.");
        }

        [Test]
        public void TestDivisione()
        {
            float num1 = 180.0f;
            float num2 = 2.0f;
            float expectedResult = 5.0f;

            float result = calculator.Divisione(num1, num2);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001f), "La divisione non � corretta.");
        }

        [Test]
        public void TestMoltiplicazione()
        {
            float num1 = 49.0f;
            float num2 = 31.0f;
            float expectedResult = 12.0f;

            float result = calculator.Moltiplicazione(num1, num2);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.001f), "La moltiplicazione non � corretta.");
        }
    }
}
    
