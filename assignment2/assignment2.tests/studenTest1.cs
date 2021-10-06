using System;
using Xunit;
using assignment2app;
namespace assignment2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void student_ToString_returns_correct_format ()
        {
            // Arange
            Student testStudent = new Student(007,"Test","test",DateTime.Parse("07-07-07"),DateTime.Parse("07-07-07"),DateTime.Parse("07-07-07"));
            String expected = "id = 7 @\n Name = Test test @\n Status = Graduated @\n StartDate = 07/07/2007 @\n EndDate = 07/07/2007 @\n GraduationDate = 07/07/2007 ";
            // Act
            String actual = testStudent.ToString();
            // Assert
            Assert.Equal(expected,actual);

        }
    }
}
