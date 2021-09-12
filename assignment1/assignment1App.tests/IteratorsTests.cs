using Xunit;
using System.Collections.Generic;
using System;
using Assignment1;
namespace Assignment1.Tests
{
    public class IteratorsTests
    {

        [Fact]
        public void Filter_false_input_from_stream()
        {
        //Given
        var input = new List<int>{1,2,3,4,5,6,7,8};
        var expected = new List<int>{2,4,6,8};

        Predicate<int> isEven = x => x % 2 == 0;
        //When
        var actual = Iterators.Filter(input,isEven);
        //Then

        Assert.Equal(expected,actual);
        }
    }
}
