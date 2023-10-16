using System;

namespace MyProject
{

    class Program
    {
        public static double SumDigits(string str)
        {
            return Convert.ToInt32(Char.GetNumericValue(str[0]) + Char.GetNumericValue(str[1]) + Char.GetNumericValue(str[2]) + Char.GetNumericValue(str[3]));
        }

        public static string ReverseDigits(string str)
        {
            return Char.ToString(str[3]) + Char.ToString(str[2]) + Char.ToString(str[1]) + Char.ToString(str[0]);
        }

        public static string LastToFirst(string str)
        {
            return Char.ToString(str[3]) + Char.ToString(str[0]) + Char.ToString(str[1]) + Char.ToString(str[2]);
        }

        public static string SecondToThird(string str)
        {
            return Char.ToString(str[0]) + Char.ToString(str[2]) + Char.ToString(str[1]) + Char.ToString(str[3]);
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(SumDigits(input));
            Console.WriteLine(ReverseDigits(input));
            Console.WriteLine(LastToFirst(input));
            Console.WriteLine(SecondToThird(input));
        }
        
    }
}