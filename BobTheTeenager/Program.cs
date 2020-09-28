using System;

namespace BobTheTeenager
{
    class Program
    {
        public static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            var helloBob = new Greeting();
            var bobsResponse = helloBob.BobsResponses(userInput);
            Console.WriteLine(bobsResponse);
        }
    }
}
