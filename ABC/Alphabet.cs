using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;


// Write a function that takes a string (word) and determines whether the word can be spelled with the given collection of blocks.
// There are twenty blocks with two letters on each block.
// A complete alphabet is guaranteed amongst all sides of the blocks.
// Once a letter on a block is used that block cannot be used again
// The function should be case-insensitive
namespace ABC
{
    public class Alphabet
    {
        public void ABC()
        {
            //declaring a 'string' type variable named 'blocks'
            string blocks = "BO XK DQ CP NA GT RE TG QD FS JW HU VI AN OB ER FS LY PC ZM"; //the sample blocks given
            // create a list for the sample words named 'words', using keyword 'new' and invoke it
            List<string> words = new List<string>() 
            {
                "A", "BARK", "BOOK", "TREAT", "COMMON", "SQUAD", "CONFUSE"
            };

            // use a loop to iterate through a singular 'word' in the 'words' list created above: new variable created for 'word' to do this
            // print each word to the screen followed by a bool value calculated using bool func below. Use of composite format {0}:{1}:
            foreach (var word in words)
            {
                Console.WriteLine("{0}: {1}", word, CheckWord(blocks, word));
            }
        }

        // Boolean function named 'CheckWord' that takes in the above 'string' variable called 'blocks' and the string variable called 'word' 
        bool CheckWord(string blocks, string word)
        {
            // for loop to determine if 'i' is less than the length of the word, increment it by one
            for (int i = 0; i < word.Length; ++i)
            {
                // integer type variable called 'length' created and assigned blocks. Method .Length ascertains the length of 'blocks' in terms of characters
                int length = blocks.Length;
                // a-z = match a character in the range of a to z and [i] = matches any character in the set. "|" = acts like a bool OR.
                // Matches the expression before or after it.  
                Regex rgx = new Regex("([a-z]" + word[i] + "|" + word[i] + "[a-z])", RegexOptions.IgnoreCase);
                // .Replace replaces all strings that match a specified regex expression with the specified replacement string "".
                blocks = rgx.Replace(blocks, "", 1);
                if (blocks.Length == length) return false;
            }
            return true;
        }
    }
}







