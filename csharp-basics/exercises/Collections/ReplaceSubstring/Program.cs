using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var wordsChanged = words.Select(word => word.Contains("ea") ? word.Replace("ea", "*") : word);
            Console.WriteLine("Result: " + string.Join(", ", wordsChanged));

            Console.WriteLine();
        }
    }
}
