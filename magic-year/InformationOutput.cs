using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    class InformationOutput
    {
        public void MagicSlip(PersonalData person)
        {
            decimal monthlySalary = Math.Round(person.AnnualSalary / 12, MidpointRounding.ToEven);
            int magicYear = (person.MagicYear + 65);
            Console.WriteLine("\nYour magic age details are: \n");
            Console.WriteLine($"Name: {person.FirstName} {person.Surname}");
            Console.WriteLine($"Monthly Salary: {monthlySalary}");
            Console.WriteLine($"Magic Year: {magicYear}");
        }
    }
}