using System;
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
                    Console.WriteLine("Not divisible by 3 and 5");
                }
                Console.ReadLine(); 
        }
    }
}
