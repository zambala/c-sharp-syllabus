using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            //for (var i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0) Console.WriteLine("Coza");
            //    else if (i % 5 == 0) Console.WriteLine("Loza");
            //    else if (i % 7 == 0) Console.WriteLine("Woza");
            //    else Console.WriteLine(i);
            //}

            for (int i = 1; i <= 110; i++)
            {


                //if (i % 3 == 0) Console.WriteLine("Coza");
                //else if (i % 5 == 0) Console.WriteLine("Loza");
                //else if (i % 7 == 0) Console.WriteLine("Woza");
                //else Console.WriteLine(i);


                if ((i % 11) == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write($"{i},");
                }

                //if (i % 3 == 0)
                //{
                //    //Console.WriteLine("Coza");

                //    string s = i.ToString("Coza");
                //    Console.WriteLine(s);
                //}
            }
        }
    }
}
