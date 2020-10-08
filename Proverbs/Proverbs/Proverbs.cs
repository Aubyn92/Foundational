using System;
using System.Collections.Generic;
using System.Linq;

namespace Proverbs
{
    public class Proverbs
    {
        public string[] WordList(string[] words)
        { 
            List<string> result = words.Select((t, i) => i == words.Length - 1
                    ? $"And all for the want of a {words[0]}."
                    : $"For want of a {t} the {words[i + 1]} was lost.")
                .ToList();
            
            return result.ToArray();
        }
    }
}