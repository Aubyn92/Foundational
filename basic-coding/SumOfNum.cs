using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class SumOfNum 

    {
        
        public void SumOfNumbers()
        {
            // Task 4: Write a program that asks the user for a number n and prints the sum of the numbers 1 to n:
            int i, sum = 0, n;
            Console.WriteLine("Please enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSum of numbers: " + sum);
            Console.ReadLine();
        }
    }
}