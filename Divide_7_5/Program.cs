using System;

namespace MyProject
{

    class Program
    {
        public static bool checkDevision(int n)
        {
            if (n % 7 == 0 || n % 5 == 0) 
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int num = int.Parse(input);
            Console.WriteLine(Program.checkDevision(num) + " NUMBER");
        }
    }
}