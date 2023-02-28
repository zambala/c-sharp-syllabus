using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayFirst = { "samuel", "MABELLE", "letitia", "meridith" };
            Console.WriteLine(string.Join(",", arrayFirst));

            CapMe(arrayFirst); 
        }
        public static string[] CapMe(string[] arrayFirst)
        {
            
            int length = arrayFirst.Length;
            string[] arraySecond = new string[length];

            for (int i = 0; i < length; i++)
            {
                arraySecond[i] = arrayFirst[i].Substring(0, 1).ToUpper() + arrayFirst[i].Substring(1).ToLower();
            }
            Console.WriteLine(string.Join(",", arraySecond));

            return arraySecond;
        }
        }
}
