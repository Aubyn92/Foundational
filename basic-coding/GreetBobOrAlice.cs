using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class GreetBobOrAlice
    {
        public void HelloBobOrAlice()
        {
            var name = "";
            while(name != "Bob" && name != "Alice")
            {
            // Task 3: Write a program that asks the user for their name and only greets you if you are Alice or Bob:
            
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            if (name.Equals("Alice") || name.Equals("Bob"))
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else
                Console.WriteLine($"Incorrect. Try again please: ");
            }
        }
    }
}