using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class Factorial
    {
        public void SumOrFactorial()
        {
            // Task 6: Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n:  

            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            int n = 0;

            bool success1 = int.TryParse(number, out n);

            if (!success1)
            {
                Console.WriteLine("Not a number");
                return;
            }

            Console.WriteLine("1. = sum of number\n2. = factorial of number");
            Console.Write("\nChoose 1 or 2: ");

            string chosen = Console.ReadLine();

            int result = -1;
            bool success2 = int.TryParse(chosen, out result);

            if (!success2)
            {
                Console.WriteLine("Not a number");
                return;
            }

            if (chosen == "1")
            {
                result = 1;
                for (int i = n; i >= 1; i--)
                    result *= i;
            }
            else if (chosen == "2")
            {
                result = 0;
                for (int i = n; i >= 1; i--)
                    result += i;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}


