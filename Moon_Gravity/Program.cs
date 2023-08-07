using System;

namespace MyProject
{

    class Program
    {
        public static float CaluclateMoonWeight(float w)
        {
            float moonGravity = 0.17f;
            return w * moonGravity;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0:0.000}", Program.CaluclateMoonWeight(75.4567f));
        }
    }
}