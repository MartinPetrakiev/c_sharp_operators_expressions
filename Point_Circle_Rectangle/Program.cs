using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            bool insideCircle = IsInsideCircle(x, y);
            bool insideRectangle = IsInsideRectangle(x, y);

            if (insideCircle && insideRectangle)
            {
                Console.WriteLine("inside rectangle inside rectangle");
            }
            else if (!insideCircle && insideRectangle)
            {
                Console.WriteLine("outside rectangle inside rectangle");
            }
            else if (insideCircle && !insideRectangle)
            {
                Console.WriteLine("inside rectangle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle outside rectangle");
            }
        }

        static bool IsInsideCircle(float x, float y)
        {
            float circleCenterX = 1;
            float circleCenterY = 1;
            float circleRadius = 1.5f;

            float distanceToCenter = (float)Math.Sqrt(Math.Pow(x - circleCenterX, 2) + Math.Pow(y - circleCenterY, 2));

            return distanceToCenter <= circleRadius;
        }

        static bool IsInsideRectangle(float x, float y)
        {
            float rectTop = 1;
            float rectLeft = -1;
            float rectWidth = 6;
            float rectHeight = 2;

            bool insideX = x >= rectLeft && x <= rectLeft + rectWidth;
            bool insideY = y <= rectTop && y >= rectTop - rectHeight;

            return insideX && insideY;
            
        }
    }
}