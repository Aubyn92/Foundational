using System;
using System.Collections.Generic;

namespace LearnCS
{
    class Program
    {
        public void Lists()
        {
            var types = new VariablesAndTypes();
            types.Variables();

            var trueOrFalse = new Conditionals();
            trueOrFalse.Bool();

            var myArray = new Arrays();
            myArray.FruitsArray();

            // var primeNumbers = new List<int>();
            // primeNumbers.AddRange();

            // var inventory = new Dictionary<string, long>();

            var name = new Strings();
            name.NameFormatting();
        }
    }
}
