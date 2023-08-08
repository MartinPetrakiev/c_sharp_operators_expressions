using System;

namespace MyProject
{
    class Program
    {
        public static float TrapezoidArea(float a, float b, float h)
        {
            return (a + b) * h / 2;
        }
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var input3 = Console.ReadLine();
            float a = float.Parse(input1);
            float b = float.Parse(input2);
            float h = float.Parse(input3);
 
            Console.WriteLine(TrapezoidArea(a, b, h).ToString("n7"));  
        }
    }
}