using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    class Task6
    {
        static void Main(string[] args)
        {
            // Task 6: Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n:  
            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();
            int n = Convert.ToInt32(number);
            Console.WriteLine("Choose 1 for the sum of your number, or 2 for the factorial of your number");
            string chosen = Console.ReadLine();

            int result = -1;

            if (chosen == "1")
            {
                result = 1;
                for (int i = n; i >= 1; i--) //loop for calculating factorial
                    result *= i;
            }
            else if (chosen == "2")
            {
                result = 0;
                for (int i = n; i >= 1; i--)  //loop for calculating sum
                    result += i;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

