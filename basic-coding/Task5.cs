using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    class Task5
    {
        static void Main(string[] args)
        {
            // Task 5: Write a program that asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five:
            int i, sum = 0, n;
            Console.WriteLine("Please enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            if (sum % 3 == 0 || sum % 5 == 0)
            {
                Console.WriteLine("\nSum of numbers: " + sum);
            }
            else
            {
                Console.WriteLine("Not divisible by 3 or 5");
            }
            Console.ReadLine();
        }
    }
}

