using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var chars = new char[] { '(', '!', '@', '#', '$', '%', '^', '&', '*', ')' };

            foreach (var number in cryptedNumbers)
            {
                Console.WriteLine(string.Join("", number.Select(e => Array.IndexOf(chars, e))));
            }
        }
    }
}
