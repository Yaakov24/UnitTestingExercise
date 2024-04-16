using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests 
    {
        [Theory]
        [InlineData(2, 0, 0, 2)]
        [InlineData(4, 3, 3, 10)]
        [InlineData(1 , 8, 0, 9)]
        [InlineData(4, 6, 5, 15)]
        [InlineData(0 , 0, 0, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

          var actual = calculator.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(10, 9, 1)]
        [InlineData(4, 5, -1)]
        [InlineData(2, 6, -4)]
        [InlineData(50, 20, 30)]
        [InlineData(2, 0, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 4 ,4)]
        [InlineData(5, 4 , 20)]
        [InlineData(7, 6, 42)]
        [InlineData(8, 4 , 32)]
        [InlineData(0, 0 , 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 5, 1.4)]
        [InlineData(7, 4,1.75)]
        [InlineData(9, 5, 1.8)]
        [InlineData( 8, 2, 4 )]
        [InlineData(0, 1 , 0 )]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
