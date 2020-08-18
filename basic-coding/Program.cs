using System;
using System.Collections.Generic;

namespace basic_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Write a program that prints ‘Hello World’ to the screen:
            // Console.WriteLine("Hello World!");

            // Task 2: Write a program that asks the user for their name and greets them with their name:
               Console.WriteLine("Please enter your name: ");
               string name = Console.ReadLine();
               Console.WriteLine($"Hello, {name}!");
        }
    }
}
