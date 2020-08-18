﻿using System;
using System.Collections.Generic;

namespace basic_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Write a program that prints ‘Hello World’ to the screen:
            //    Console.WriteLine("Hello World!");

            // Task 2: Write a program that asks the user for their name and greets them with their name:
            //    Console.WriteLine("Please enter your name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Hello, {name}!");

            // Task 3: Write a program that asks the user for their name and only greets you if you are Alice or Bob:
            //    Console.WriteLine("Please enter your name: ");
            //    string name = Console.ReadLine();
            //    if (name.Equals("Alice") || name.Equals("Bob"))
            //    {
            //    Console.WriteLine($"Hello, {name}!");
            //    }
            //    else
            //    Console.WriteLine($"Your name is incorrect. Rename yourself please.");

            // Task 4: Write a program that asks the user for a number n and prints the sum of the numbers 1 to n:
            //    int i, sum = 0, n;
            //    Console.WriteLine("Please enter a number: ");
            //    n = int.Parse(Console.ReadLine());
            //    for (i = 0; i <= n; i++) 
            //    {
            //        sum = sum + i;
            //    }
            //    Console.WriteLine("\nSum of numbers: " + sum);
            //    Console.ReadLine();

            // Task 5: Write a program that asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five:
            //    int i, sum = 0, n;
            //    Console.WriteLine("Please enter a number: ");
            //    n = int.Parse(Console.ReadLine());
            //    for (i = 0; i <= n; i++) 
            //    {
            //       sum = sum + i;
            //    }
            //    if (sum % 3 == 0 || sum % 5 == 0)
            //    {
            //       Console.WriteLine("\nSum of numbers: " + sum);
            //    }
            //    else 
            //    {
            //       Console.WriteLine("Not divisible by 3 or 5");
            //    }
            //    Console.ReadLine();

            // Task 6: Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n:  
            //    Console.WriteLine("Please enter a number: ");
            //    string number = Console.ReadLine();
            //    int n = Convert.ToInt32(number);
            //    Console.WriteLine("Choose 1 for the sum of your number, or 2 for the factorial of your number");
            //    string chosen = Console.ReadLine();

            //    int result = -1;

            //    if (chosen == "1")
            //    {
            //       result = 1;
            //       for (int i = n; i >= 1; i--) //loop for calculating factorial
            //       result *= i;
            //    }
            //    else if (chosen == "2")
            //    {
            //       result = 0;
            //       for (int i = n; i >= 1; i--)  //loop for calculating sum
            //       result += i;
            //    }
            //    Console.WriteLine(result);
            //    Console.ReadLine();

            // Task 7: Write a program that prints a multiplication table for numbers up to 12:
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}


