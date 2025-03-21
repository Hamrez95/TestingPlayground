using NUnit.Framework;
using NUnit.Framework.Legacy;
using StaticSamples;

namespace StaticSamplesUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTest
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Sum(10, 20);

            //Assert
            ClassicAssert.AreEqual(30, result);
            // always should write like this : (expected result , actual result)
        }

        [Test]
        public void IsOddChecker_InputOddNumber_ReturnTrue()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.Is_Number_Odd(5);

            //Assert
            ClassicAssert.AreEqual(true, result);
             Assert.That(result, Is.True);
            
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.Is_Number_Odd(6);

            //Assert
            ClassicAssert.AreEqual(false, result);
            Assert.That(result, Is.False);

        }
    }
}
