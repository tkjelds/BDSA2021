using System;
using System.IO;
using Xunit;

namespace assignment0.tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            // arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // act
            Program.Main(new String[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("Hello, World!",output);
        }

        [Fact]
        public void Leap_Year_returns_True_when_given_number_divisible_by_four()
        {
            //Given
            var Program = new Program();
            var year = 4;
            var expected = true;
            //When
            var actual = Program.IsLeapYear(year);

            //Then
            Assert.Equal(actual,expected);
        }

        [Fact]
        public void Leap_Year_Returns_False_given_number_divisible_by_100_and_4()
        {
        //Given
            var Program = new Program();
            var year = 100;
            var expected = false;
        //When
            var actual = Program.IsLeapYear(year);
        //Then
            Assert.Equal(actual,expected);
        }
        [Fact]
        public void Leap_Year_returns_true_given_great_leap_year()
        {
        //Given
            var Program = new Program();
            var year = 400;
            var expected = true;
        //When
            var actual = Program.IsLeapYear(year);
        //Then
            Assert.Equal(actual,expected);
        }
    }
}
