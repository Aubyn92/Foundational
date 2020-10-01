using System;

namespace callMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a ten digit phone number: ");
            var userInput = Console.ReadLine();
            var enterNumber = new StringTransform();
            var receivedNumber = enterNumber.TransformPhoneNumber(userInput);
            Console.WriteLine(receivedNumber);
        }
    }
}
