using System;

namespace MyProject
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            bool IsPrime = true;

            if (number == 1)
            {
                IsPrime = false;
            }

            var boundary = Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            return IsPrime;
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(N));
        }
    }
}