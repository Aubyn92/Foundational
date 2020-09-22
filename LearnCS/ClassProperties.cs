using System;

namespace LearnCS
{
    public class ClassProperties
    {
        string Type;
        int NumTires;
        int Year;
        bool Runs;
        public ClassProperties(string type, int numTires, int year, bool runs)
        {
            Type = type;
            NumTires = numTires;
            Year = year;
            Runs = runs;
        }

        public void Vehicle()
        {
            var car = new ClassProperties("car", 4, 2000, true);
            var oldCar = new ClassProperties("car", 4, 1980, false);
            var bike = new ClassProperties("bike", 2, 2017, true);

            Console.WriteLine(car.Type);
            Console.WriteLine(oldCar.Runs);
            Console.WriteLine(bike.NumTires);
        }
    }
}