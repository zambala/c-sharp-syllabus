using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text");
            string text = Console.ReadLine().ToUpper();

            string[] str
              = { "2",    "22",  "222", "3",   "33", "333",
                 "4",    "44",  "444", "5",   "55", "555",
                 "6",    "66",  "666", "7",   "77", "777",
                 "7777", "8",   "88",  "888", "9",  "99",
                 "999",  "9999" };

            Console.WriteLine(phoneKeys(str, text));
        }

        static String phoneKeys(string[] arr, string text)
        {
            string result = "";

            int n = text.Length;
            for (int i = 0; i < n; i++)
            {
                if (text[i] == ' ')
                {   result = result + "0";}
                else
                {
                    int position = text[i] - 'A';
                    result = result + arr[position];
                }
            }
            return result;
        }
    }
}