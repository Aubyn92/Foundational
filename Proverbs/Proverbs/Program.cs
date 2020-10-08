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
            newInstanceOfWordList.WordList(new string[] {"nail", "shoe", "horse", "rider", "message", "battle", "kingdom"});
        }
    }
}