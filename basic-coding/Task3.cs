using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    class Task3
    {
        static void Main(string[] args)
        {
            // Task 3: Write a program that asks the user for their name and only greets you if you are Alice or Bob:
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            if (name.Equals("Alice") || name.Equals("Bob"))
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else
                Console.WriteLine($"Your name is incorrect. Rename yourself please.");
        }
    }
}