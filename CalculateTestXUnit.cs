using My_Calculator;
using System;
using Xunit;

namespace My_CalculatorTestXUnit
{
    public class CalculateTestXUnit
    {

        [Fact]
        public void Correctly_Calculate_Two_Numbers_With_Subtraction()
        {
            //Arrange
            var cal = new Calculate() { Input1 = 100, Input2 = 1 };

            //Act
            cal.Subtraction();
            var expected = 99;

            //Assert
            Assert.Equal(expected, cal.Result);

        }

        [Fact]
        public void Correctly_Calculate_Two_Numbers_With_Multiplication()
        {
            //Arrange
            var cal = new Calculate() { Input1 = 10, Input2 = 10 };

            //Act
            cal.Multiplication();
            var expected = 100;

            //Assert
            Assert.Equal(expected, cal.Result);
        }

        [Fact]
        public void Correctly_Claculate_Two_Numbers_With_Division()
        {
            //Arrange
            var cal = new Calculate() { Input1 = 100, Input2 = 10 };

            //Act
            cal.Division();
            var expected = 10;

            //Assert
            Assert.Equal(expected, cal.Result);
        }

        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(100, 100, 200)]
        [InlineData(33.33, 33.45, 66.78)]
        [InlineData(1, 1, 2)]
        [InlineData(-2, 5, 3)]
        public void Correctly_Calculate_Two_Numers_With_Addition(decimal Input1, decimal Input2, decimal expected)
        {
            //Arrange
            var cal = new Calculate();
            //Act
            cal.Addition(Input1, Input2);
            //Assert
            Assert.Equal(expected, cal.Result);

        }






        //    [Fact]
        //    public void Correctly_Calculate_Two_Numbers_With_Addition()
        //    {
        //        Arrange
        //        var cal = new Calculate() { Input1 = 10, Input2 = 10 };


        //        Act
        //        cal.Addition();
        //        var expected = 20;

        //        Assert
        //        Assert.Equal(expected, cal.Result);
        //    }
    }
}
