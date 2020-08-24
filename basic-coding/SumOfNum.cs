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
            int i, sum = 0, num;

            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            num = 0;
            bool success = int.TryParse(userInput, out num);

            if (!success)
            {
                Console.WriteLine("Not a number");
                return;
            }

            for (i = 0; i <= num; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("\nSum of numbers: " + sum);
            Console.ReadLine();
        }
    }
}