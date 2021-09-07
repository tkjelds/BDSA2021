using System;
using System.IO;
using Xunit;
using static assignment0.Program;

namespace assignment0.tests
{

    public class fakeUserInputReturns_ABCD : IGetInput
    {
        public string getInput()
        {
            return "ABCD";
        }
    }
    public class fakeUserInputReturns_400 : IGetInput
    {
        public string getInput()
        {
            return "400";
        }
    }
    public class fakeUserInputReturns_100 : IGetInput
    {
        public string getInput()
        {
            return "100";
        }
    }
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
            var actual = Program.isLeapYear(year);

            //Then
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Leap_Year_Returns_False_given_number_divisible_by_100_and_4()
        {
        //Given
            var Program = new Program();
            var year = 100;
            var expected = false;
        //When
            var actual = Program.isLeapYear(year);
        //Then
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Leap_Year_returns_true_given_great_leap_year()
        {
        //Given
            var Program = new Program();
            var year = 400;
            var expected = true;
        //When
            var actual = Program.isLeapYear(year);
        //Then
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void YayOrNay_given_400(){


            //Given
            var program = new Program(); 
            var input = new fakeUserInputReturns_400();
            var writer = new StringWriter();
            Console.SetOut(writer);
            var expected = "Yay";
            // act
            program.yayOrNay(input);
            var actual = writer.GetStringBuilder().ToString().Trim();
            //Then

            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void YayOrNay_given_abcd_fails_conversions()
        {
        //Given
        var userInput = new fakeUserInputReturns_ABCD();
        var program = new Program();
        var writer = new StringWriter();
        Console.SetOut(writer);
        var expected = "Failed conversion of: ABCD";
        //When
        program.yayOrNay(userInput);
        var actual = writer.GetStringBuilder().ToString().Trim();
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void YayOrNay_given_100_returns_Nay()
        {
        var userInput = new fakeUserInputReturns_100();
        var program = new Program();
        var writer = new StringWriter();
        Console.SetOut(writer);
        var expected = "Nay";
        //When
        program.yayOrNay(userInput);
        var actual = writer.GetStringBuilder().ToString().Trim();
        //Then
        Assert.Equal(expected,actual);
        }

    }
}
