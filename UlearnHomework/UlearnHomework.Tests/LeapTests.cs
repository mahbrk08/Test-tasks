using System;
using Xunit;

namespace UlearnHomework.Tests
{
    public class LeapTests
    {
        [Theory]
        [InlineData(2000, 2004, 2)]
        [InlineData(1999, 2004, 2)]
        [InlineData(2000, 2005, 2)]
        [InlineData(2000, 2024, 7)]
        [InlineData(2000, 2000, 1)]
        [InlineData(2001, 2001, 0)]
        [InlineData(2001, 2003, 0)]
        // Полноценный Григорианский календарь
        [InlineData(2100, 2100, 0)]
        [InlineData(2000, 2500, 126-5+2)] // Вычитаем 5 лет делящихся на 100, и прибавляем 2 делящихся на 400
        public void Test1(int start, int end, int expectedResult)
        {
            // Act
            var result = Program.LeapYear(start, end);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}