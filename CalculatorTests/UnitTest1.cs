using Calculator;
using Calculator.Patterns;

namespace CalculatorTests
{
    public class Tests
    {
        //Arrange
        CalculatorClass calculator = new CalculatorClass();

        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase(2 ,3, 5)]
        [TestCase(10, 5, 15)]
        [TestCase(8, 9, 17)]
        [TestCase(20, 21, 41)]
        [TestCase(12, 13, 25)]
        public void TestForPlus(int a, int b, int excepted)
        {
            //Arange
            calculator.SetOperation(new Plus());

            //Act
            int result = calculator.DoCalulate(a, b);

            //Assert
            Assert.AreEqual(result, excepted);
        }

        [TestCase(10, 5, 5)]
        [TestCase(15, 5, 10)]
        [TestCase(100, 41, 59)]
        [TestCase(2, 1, 1)]
        [TestCase(39, 9, 30)]
        public void TestForMinus(int a, int b, int excepted)
        {
            //Arange
            calculator.SetOperation(new Minus());

            //Act
            int result = calculator.DoCalulate(a, b);

            //Assert
            Assert.AreEqual(result, excepted);
        }

        [TestCase(5, 5, 25)]
        [TestCase(10, 5, 50)]
        [TestCase(15, 2, 30)]
        [TestCase(2, 5, 10)]
        [TestCase(4, 3, 12)]
        public void TestForMultiply(int a, int b, int excepted)
        {
            //Arange
            calculator.SetOperation(new Multiply());

            //Act
            int result = calculator.DoCalulate(a, b);

            //Assert
            Assert.AreEqual(result, excepted);
        }

        [TestCase(10, 2, 5)]
        [TestCase(100, 50, 2)]
        [TestCase(29, 1, 29)]
        [TestCase(88, 11, 8)]
        [TestCase(26, 13, 2)]
        public void TestForDivide(int a, int b, int excepted)
        {
            //Arange
            calculator.SetOperation(new Divide());

            //Act
            int result = calculator.DoCalulate(a, b);

            //Assert
            Assert.AreEqual(result, excepted);
        }

        [TestCase(10, 0)]
        [TestCase(1, 0)]
        [TestCase(999, 0)]
        public void TestIsDivideByZero(int a, int b)
        {
            //Arange
            calculator.SetOperation(new Divide());

            //Assert
            Assert.Throws<DivideByZeroException>(() => { calculator.DoCalulate(a, b); });
        }
    }
}