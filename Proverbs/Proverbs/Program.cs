using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Proverbs
{
    class Program
    {
        static void Main(string[] args)
        {
            var newInstanceOfWordList = new Proverbs();
            
            // need to store newInstanceOfWordList in its own variable in order to run method 'WordList' on it
            var arrayOfWords = newInstanceOfWordList.WordList(new string[] {"nail", "shoe", "horse", "rider", "message", "battle", "kingdom"});
            
            // need to use method 'Join' in order for it to print correctly
            Console.WriteLine(string.Join("\n", arrayOfWords));
        }
    }
}