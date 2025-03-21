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
    }
}
