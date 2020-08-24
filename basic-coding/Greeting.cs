using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class Greeting
    {
        public void GreetUser()
        {
            // Task 2: Write a program that asks the user for their name and greets them with their name:

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty! Input your name again: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
        }
    }
}