using Xunit;
using Assignment1;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_given_empty_list()
        {
        //Given
        var input = new List<string>{};
        var expected = new List<string>{};
        //When
        var actual = RegExpr.SplitLine(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void SplitLine_given_non_empty_list_returns()
        {
        //Given
        var input = new List<string>{"this is a test", "this;is;a;test"};
        var expected = new List<string>{"this","is","a","test","this","is","a","test"};
        //when
        var actual = RegExpr.SplitLine(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Resolution_given_empty_list()
        {
        //Given
        var input = "";
        var expected = new List<(int,int)>();
        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Resolution_given_list_with_resolutions()
        {
        //Given
        var input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";
        var expected = new List<(int,int)>{
            (1920, 1080),
            (1024, 768),
            (800, 600),
            (640, 480),
            (320, 200),
            (320, 240),
            (800, 600),
            (1280, 960)
        };
        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Resolution_given_list_with_resolutions_and_words()
        {
        //Given
        var input = "1920x1080 1024x768, this 800x600, 640x480 is320x200, 320x240,  not 800x600 supposed to be here 1280x960";
        var expected = new List<(int,int)>{
            (1920, 1080),
            (1024, 768),
            (800, 600),
            (640, 480),
            (320, 200),
            (320, 240),
            (800, 600),
            (1280, 960)
        };
        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(expected,actual);
        }
    }
}
