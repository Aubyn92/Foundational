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

            var name = new Strings();
            name.NameFormatting();
        }
    }
}
