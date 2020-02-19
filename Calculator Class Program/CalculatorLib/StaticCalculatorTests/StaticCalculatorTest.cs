using NUnit.Framework;
using CalculatorLib;

namespace StaticCalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //ADDITION FUNCTION UNIT TEST
        [TestCase(2, 4, 6)] //Should return a positive result
        [TestCase(2, -4, 6)] //Should return an error, result should be -2
        [TestCase(-2, -4, -6)] //Positive
        [TestCase(6, 0, 6)]
        [Test]
        public void calcAddTest(int num1, int num2, int expectedResult)
        {
            //Arrange
            //Act
            int calcResult = CalculatorMethod.calcAdd(num1, num2);
            //Assert - Compares expected result with the outcome of your method
            Assert.AreEqual(expectedResult, calcResult, "Calculation returns an error"); 
        }

        //SUBTRACTION FUNCTION UNIT TEST
        [TestCase(2, 4, -2)] 
        [TestCase(-2, -4, 6)] 
        [TestCase(6, 4, 2)]
        [TestCase(6, 0, 6)]
        [Test]
        public void calcSubTest(int num1, int num2, int expectedResult)
        {
            //Arrange
            //Act
            int calcResult = CalculatorMethod.calcSub(num1, num2);
            //Assert - Compares expected result with the outcome of your method
            Assert.AreEqual(expectedResult, calcResult, "Calculation returns an error");
        }

        //DIVISION FUNCTION UNIT TEST
        [TestCase(2, 0, 0)] 
        [TestCase(4, 2, 2)] 
        [TestCase(6, 5, 1)]
        [TestCase(6, -2, 3)]
        [Test]
        public void calcDivTest(int num1, int num2, int expectedResult)
        {
            //Arrange
            //Act
            int calcResult = CalculatorMethod.calcDiv(num1, num2);
            //Assert - Compares expected result with the outcome of your method
            Assert.AreEqual(expectedResult, calcResult, "Calculation returns an error");
        }

        //MULTIPLICATION FUNCTION UNIT TEST
        [TestCase(2, 0, 0)] 
        [TestCase(2, -4, -8)] 
        [TestCase(-2, -4, 8)] 
        [Test]
        public void calcMulTest(int num1, int num2, int expectedResult)
        {
            //Arrange
            //Act
            int calcResult = CalculatorMethod.calcMul(num1, num2);
            //Assert - Compares expected result with the outcome of your method
            Assert.AreEqual(expectedResult, calcResult, "Calculation returns an error");
        }

        //MODULAR FUNCTION UNIT TEST
        [TestCase(6, 4, 2)] 
        [TestCase(8, -4, 6)] 
        [TestCase(-4, -4, 0)] 
        [Test]
        public void calcModTest(int num1, int num2, int expectedResult)
        {
            //Arrange
            //Act
            int calcResult = CalculatorMethod.calcMod(num1, num2);
            //Assert - Compares expected result with the outcome of your method
            Assert.AreEqual(expectedResult, calcResult, "Calculation returns an error");
        }
    }
}