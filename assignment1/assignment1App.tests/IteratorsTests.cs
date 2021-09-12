using Xunit;
using System.Collections.Generic;
using System;
using Assignment1;
namespace Assignment1.Tests
{
    public class IteratorsTests
    {

        [Fact]
        public void Flatten_returns_emptylist_given_emptyList()
        {
        //Given
        var input = new List<List<int>>{};
        var expected = new List<int>{};
        //When
        var actual = Iterators.Flatten(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Flatten_lists_list_into_single_list()
        {
        //Given
        var input = new List<List<int>>{
            new List<int>{1,2,3},
            new List<int>{1,2,3},
            new List<int>{1,2,3}
        };
        var expected = new List<int>{1,2,3,1,2,3,1,2,3};
        //When
        var actual = Iterators.Flatten(input);
        //Then
        Assert.Equal(expected,actual);
        }



        [Fact]
        public void Filter_given_empty_list_returns_emptyList()
        {
        //Given
        var input = new List<int>{};
        var expected = new List<int>{};
        Predicate<int> isEven = x => x%2 == 0;
        //When
        var actual = Iterators.Filter(input,isEven);
        //Then
        Assert.Equal(expected,actual);
        }

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
