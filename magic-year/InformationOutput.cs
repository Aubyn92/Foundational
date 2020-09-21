using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    public class InformationOutput
    {
        public void MagicSlip(PersonalData person, IUserContentInterface userContentIo)
        {
            decimal monthlySalary = Math.Round(person.AnnualSalary / 12, MidpointRounding.ToEven);
            int magicYear = (person.StartYear + 65);
            userContentIo.WriteLine("\nYour magic age details are: \n");
            userContentIo.WriteLine($"Name: {person.FirstName} {person.Surname}");
            userContentIo.WriteLine($"Monthly Salary: {monthlySalary}");
            userContentIo.WriteLine($"Magic Year: {magicYear}");
        }
    }
}