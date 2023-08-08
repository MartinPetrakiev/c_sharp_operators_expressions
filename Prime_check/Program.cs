using System;

namespace MyProject
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            int countDevisions = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    countDevisions++;
                }
            }

            if (countDevisions == 2)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int num = int.Parse(input);

            Console.WriteLine(IsPrime(num));
            
        }
    }
}