using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BobTheTeenager
{
    public class Greeting
    {
        public string BobsResponses(string greeting)
        {
            greeting = greeting.Trim();
            if (greeting == "")
            {
                Console.WriteLine("Fine. Be that way!");
            }
            else if(Regex.IsMatch(greeting, "[A-Z]") && !Regex.IsMatch(greeting, "[a-z]"))
            {
                Console.WriteLine("Calm down, I know what I'm doing!");
            }
            else if(greeting.Substring(greeting.Length - 1) == "?")
            {
                Console.WriteLine("Sure.");
            }
            // else if()
            // {
            //     Console.WriteLine("Whoa, chill out!");
            // }
            return "Whatever.";
        }
    }
}