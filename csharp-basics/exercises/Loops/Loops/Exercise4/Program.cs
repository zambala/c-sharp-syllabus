using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //todo - use for
            Console.Write("Vowels with FOR \n");
            for(int i = 0; i < vowels.Length; i++) 
            {
                Console.Write(vowels[i] + " ");
            }
            Console.WriteLine("\n");
            Console.Write("Vowels with FOREACH \n");
            foreach (char letter in vowels)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
