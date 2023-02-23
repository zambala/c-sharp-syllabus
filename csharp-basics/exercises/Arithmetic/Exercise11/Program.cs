using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Harshad(132);
            Harshad(27);
            Harshad(22);
        }
        public static int SumDigits (int numb)
        {
            //Console.WriteLine("Enter a Number");

            //int numb = int.Parse(Console.ReadLine());

            
            int sum = 0;

            for (int i = numb; i > 0; i = i / 10)
            {
                sum = sum + i % 10;

             }
            return sum;
         }

        public static bool IsPrime(int numb)
        {
            if (numb <= 1) return false;
            if (numb == 2) return true;
            if (numb % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(numb));

            for (int i = 3; i <= boundary; i += 2)
                if (numb % i == 0)
                    return false;

            return true;
        }
        public static bool IsMoran(int numb)
        {
            IsPrime(numb);
            int sum = SumDigits(numb);

            if ((numb % sum) != 0)
            {
                return false;
            }

            int div = numb / sum;

            if (IsPrime(div))
            {
                return true;
            }
            return false;
        }
        public static string Harshad(int numb)
        {
            IsMoran(numb);
            string response = "";
            int sum = SumDigits(numb);
            

            if(IsMoran(numb))
            {
                Console.WriteLine("Moran");
            }
            else if (numb % sum == 0)
            {
                Console.WriteLine("Harshad");
            }
            else
            {
                Console.WriteLine("Neither");
            }

            return response;
        }
    }
}
