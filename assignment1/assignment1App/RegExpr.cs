using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            var pattern = @"(\w+)";
            var rx = new Regex(pattern);
            foreach (var line in lines)
            {
                var match = rx.Match(line);
                while(match.Success){
                    yield return match.Value;
                    match = match.NextMatch();
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var pattern = @"(?<width>\d+)x(?<height>\d+)";
            var rx = new Regex(pattern);
            var match = rx.Match(resolutions);
            while(match.Success){
                var width = int.Parse(match.Groups["width"].Value);
                var height = int.Parse(match.Groups["height"].Value);
                yield return (width,height);
                match = match.NextMatch();
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
