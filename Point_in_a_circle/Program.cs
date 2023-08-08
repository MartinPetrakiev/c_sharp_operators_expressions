using System;

namespace MyProject
{
    class Program
    {
        public static bool CheckCoordinates(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            double x = Convert.ToDouble(input1);
            double y = Convert.ToDouble(input2);
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (CheckCoordinates(x, y)) 
            {
                Console.WriteLine("yes " + distance.ToString("0.00"));
            }
            else 
            {
                Console.WriteLine("no " + distance.ToString("0.00"));
                
            }
        }
    }
}