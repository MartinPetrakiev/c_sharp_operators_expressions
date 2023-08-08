using System;
using System.Collections;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            // BitArray b = new BitArray(new int[] { num }); 

            // Console.WriteLine(b[2] ? 1 : 0);
            string bitNumToString = Convert.ToString(num, 2);

            Console.WriteLine(bitNumToString[2]);
        }
        
    }
}