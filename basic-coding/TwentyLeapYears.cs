using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class TwentyLeapYears
    {
        public static void LeapYears()
        {
            {
                Console.Write("Enter a year(YYYY): ");
                string stringChosenYear = Console.ReadLine();

                int newYear = int.Parse(stringChosenYear);

                Console.WriteLine("The next 20 leap years are: ");
                for (int year = newYear; year >= 1752; year++)
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine(year);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}



