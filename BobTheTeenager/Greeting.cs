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
                return "Fine. Be that way!";
            }
            else if(Regex.IsMatch(greeting, "[/?]") && Regex.IsMatch(greeting, "[/!]"))
            {
                return "Calm down, I know what I'm doing!";
            }
            else if(greeting.Substring(greeting.Length - 1) == "?")
            {
                return"Sure.";
            }
            else if(Regex.IsMatch(greeting, "[/!]"))
            {
                return "Whoa, chill out!";
            }
            return "Whatever.";
        }
    }
}