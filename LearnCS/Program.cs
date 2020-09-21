using System;
using System.Collections.Generic;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new VariablesAndTypes();
            types.Variables();

            var trueOrFalse = new Conditionals();
            trueOrFalse.Bool();

            var myArray = new Arrays();
            myArray.FruitsArray();

            List<int> primeNumbers = new List<int>();
            primeNumbers.PrimeNumList();
        }
    }
}
