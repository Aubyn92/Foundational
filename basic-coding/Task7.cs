using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    class Task7
    {
        static void Main(string[] args)
        {
            // Task 7: Write a program that prints a multiplication table for numbers up to 12:
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
