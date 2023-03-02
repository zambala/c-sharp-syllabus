using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Happy Birthday";
            string str2 = "MANY THANKS";
            string str3 = "sPoNtAnEoUs";

            ReverseCase(str1);
            ReverseCase(str2);
            ReverseCase(str3);
        }

        static void ReverseCase(string sentence)
        {
            var charArray = sentence.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    Console.Write(char.ToLower(charArray[i]));
                }
                else
                {
                    Console.Write(char.ToUpper(charArray[i]));
                }
            }

            Console.WriteLine();
        }
    }
}
