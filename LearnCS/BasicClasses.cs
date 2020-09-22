using System;

namespace LearnCS
{
    class BasicClasses
    {
        int numTires = 4;
        int year = 2000;
        bool runs = true;
        public void Car()
        {
            var car1 = new BasicClasses();
            car1.Car();

            var car2 = new BasicClasses();
            car2.Car();

            var car3 = new BasicClasses();
            car3.Car();

            Console.WriteLine(car1.numTires);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.runs);
        }
    }
}