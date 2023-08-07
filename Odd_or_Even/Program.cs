﻿using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> num = null;
            string s = Console.ReadLine();

            try {
                num = int.Parse(s);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid integer!");
                return;
            }

            if (num % 2 == 0) {
                Console.WriteLine("Even");
            }
            else 
            {
                Console.WriteLine("Odd");
            }
        }
    }
}