using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BobTheTeenager
{
    public class OutputInput
    {
        public static string BobsResponses(string greeting)
        {
            greeting = greeting.Trim();
            if (greeting == "")
            {
                return "Fine. Be that way!";
            }
            else if(Regex.IsMatch(greeting, "[A-Z]") && !Regex.IsMatch(greeting, "[a-z]"))
            {
                return "Calm down, I know what I'm doing!";
            }
            else if(greeting.Substring(greeting.Length - 1) == "?") ?
            {
                return "Sure.";
            }
            // else if()
            // {
            //     return "Whoa, chill out!";
            // }
            return "Whatever.";
        }
    }
}