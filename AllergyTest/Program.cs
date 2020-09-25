using System;
using System.Collections.Generic;
using System.Linq;

namespace AllergyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var userInput = int.Parse(Console.ReadLine());
            var newAllergyScore = new PersonAllergyScore(userInput);
            var newList = newAllergyScore.List();
            string result = string.Join(", ", newList);
            Console.WriteLine($"Your allergies: {result}");
        }
    }
}