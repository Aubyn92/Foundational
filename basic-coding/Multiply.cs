using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class Multiply
    {
        public void Multiplication()
        {
            // Task 7: Write a program that prints a multiplication table for numbers up to 12:
            int num = 0;

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            bool success = int.TryParse(userInput, out num);

            if (!success)
            {
                Console.WriteLine("Not a number");
                return;
            }

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("\n{0} * {1} = {2}", num, i, num * i);
            }
            Console.ReadLine();
        }
    }
}
