using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    class Program
    {
        static void Main(string[] args)
{
            // Task 1: Write a program that prints ‘Hello World’ to the screen:
            // Console.WriteLine("Hello World!");
            var hello1 = new GreetBobOrAlice();
            hello1.HelloBobOrAlice();

            var div1 = new Division();
            div1.SumDivision();

            var fac1 = new Factorial();
            fac1.SumOrFactorial();

            var greeting1 = new Greeting();
            greeting1.GreetUser();

            var guess1 = new GuessTheNumber();
            guess1.GuessingGame();
            
            var math1 = new Multiply();
            math1.Multiplication();

            var output1 = new SumOfNum();
            output1.SumOfNumbers();

            var yr1 = new TwentyLeapYears();
            yr1.LeapYears();

        }
    }
}















