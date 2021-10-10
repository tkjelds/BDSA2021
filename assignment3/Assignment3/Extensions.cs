using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        static int WordCount(this string str) => str.Split(' ').Where(s => s.All(char.IsLetter)).Count();
    }
}
