using System;

namespace MyProject
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            bool IsPrime = true;

            if (number <= 1)
            {
                IsPrime = false;
            }
            else if (number == 2 || number == 3 || number == 5)
            {
                IsPrime = true;
            }
            else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
            {
                IsPrime = false;
            }
            else
            {
                int boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 7; i <= boundary; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                    {
                        IsPrime = false;
                        break;
                    }
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