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

            var car1 = new BasicClasses();
            car1.Car();

            var car2 = new BasicClasses();
            car2.Car();

            var car3 = new BasicClasses();
            car3.Car();
        }
    }
}
