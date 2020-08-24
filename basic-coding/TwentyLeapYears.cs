using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class TwentyLeapYears
    {
        public void LeapYears()
        {
            {
                Console.Write("Enter a year(YYYY): ");
                string stringChosenYear = Console.ReadLine();

                int newYear = 0;
                bool success = int.TryParse(stringChosenYear, out newYear);

                if (!success)
                {
                    Console.WriteLine("Not a number");
                    return;
                }

                if (newYear < 1752)
                {
                    newYear = 1751;
                }

                Console.WriteLine("The next 20 leap years are: ");
                int numOfLeapYears = 0;
                for (int year = newYear + 1; numOfLeapYears < 20; year++)
                {
                    if (year % 4 == 0)
                    {
                        numOfLeapYears++;
                        Console.WriteLine(year);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}




