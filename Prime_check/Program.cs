using System;

namespace MyProject
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            bool IsPrime = false;

            if (number == 2 || number == 3 || number == 5)
            {
                IsPrime = true;
            }
            else
            {
                double n = Math.Round((double)number / 6);

                if (n < (double)number / 6)
                {
                    n = 6 * n + 1;

                    if (n == number)
                    {
                        IsPrime = true;
                    }
                }
                else
                {
                    n = 6 * n - 1;
                    if (n == number)
                    {
                        IsPrime = true;
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