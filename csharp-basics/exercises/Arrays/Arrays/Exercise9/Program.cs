using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayFirst = { "samuel", "MABELLE", "letitia", "meridith" };

        }



        public static string CapMe(string[] arrayFirst)
        {
            
            int length = arrayFirst.Length;
            string[] arraySecond = new string[length];


            foreach (string word in arrayFirst)
            {
                Console.WriteLine(word[0]);
            }
            return arraySecond[arrayFirst[]];

        }
        }
}
