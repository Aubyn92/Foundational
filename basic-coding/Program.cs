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
            var yr1 = new TwentyLeapYears();
            yr1.LeapYears();
            
            SumOfNum output1 = new SumOfNum();
            Multiply math1 = new Multiply();
            GuessTheNumber guess1 = new GuessTheNumber();
            Greeting greeting1 = new Greeting();
            GreetBobOrAlice hello1 = new GreetBobOrAlice();
            Factorial fac1 = new Factorial();
            Division div1 = new Division();
            Console.WriteLine("Hello World!");
            // SumOfNum.SumOfNumbers();
            // Multiply.Multiplication();
            // GuessTheNumber.GuessingGame();
            // Greeting.GreetUser();
            // GreetBobOrAlice.HelloBobOrAlice();
            // Factorial.SumOrFactorial();
            // Division.SumDivision();
        }
    }
}















