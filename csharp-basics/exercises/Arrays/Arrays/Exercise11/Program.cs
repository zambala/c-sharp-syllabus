using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNemo("I am finding Nemo !"));
            Console.WriteLine(FindNemo("Nemo is me"));
            Console.WriteLine(FindNemo("I Nemo am"));
        }

        public static string FindNemo(string sentence)
        {
            var index = Array.IndexOf(sentence.Split(' '), "Nemo");
            if (index < 0)
            { 
                return "I can't find Nemo :("; 
            }
            else { 
                return $"I found Nemo at {index + 1}!";
            }
        }
    }
}
