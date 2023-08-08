using System;

namespace MyProject
{

    class Program
    {
        public static bool CheckThirdDigit(string str)
        {
            if (str == null)
            {
                return false;
            }
            else if (str.Length > 2)
            {
                char digitChar = str[str.Length - 3];
                if (Char.GetNumericValue(digitChar) == 7)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (CheckThirdDigit(input))
            {
                Console.WriteLine(true);
            }
            else if (input.Length > 2 && !CheckThirdDigit(input))
            {
                Console.WriteLine(false.ToString() + " " + input[input.Length - 3]);
            }
            else
            {
                Console.WriteLine(false + " 0");
            }
        }
    }
}