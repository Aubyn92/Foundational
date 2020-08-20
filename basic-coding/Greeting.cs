using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class Greeting
    {
         public static void GreetUser()
        {
            // Task 2: Write a program that asks the user for their name and greets them with their name:
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}