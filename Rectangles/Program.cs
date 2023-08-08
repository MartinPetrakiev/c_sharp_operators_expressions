using System;

namespace MyProject
{

    class Program
    {
        public static float calculateArea(float w, float h)
        {
            return (float)w * (float)h;
        }

        public static float calculatePerimeter(float w, float h)
        {
            return 2 * (float)w + 2 * (float)h;
        }
        static void Main(string[] args)
        {
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());

            float area = calculateArea(width, height);
            float perimeter = calculatePerimeter(width, height);

            Console.Write("{0:0.00}", area);
            Console.Write(" ");
            Console.Write("{0:0.00}", perimeter);

        }
    }
}