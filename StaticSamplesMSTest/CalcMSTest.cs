using Microsoft.CodeCoverage.Core.Reports.Cobertura;
using StaticSamples;

namespace StaticSamplesMSTest
{
    [TestClass]
    public sealed class CalcMSTest
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Sum(10, 20);

            //Assert
            Assert.AreEqual(30 , result);
            // always should write like this : (expected result , actual result)
        }
    }
}
