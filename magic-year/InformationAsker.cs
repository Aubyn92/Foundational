using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    class InformationAsker
    {
        public PersonalData MagicDetails()
        {
            Console.WriteLine("Welcome to the Magic Year Calculator!\n");
            var informationStorer = new InformationStorer();
            string firstName = informationStorer.ReadString("Enter your first name: ");
            string surname = informationStorer.ReadString("Enter your surname: ");
            decimal annualSalary = informationStorer.ReadDecimal("Enter your annual salary: $");
            int startYear = informationStorer.ReadInt("Enter your work start year: ");
            return new PersonalData(firstName, surname, annualSalary, startYear);
        }
    }
}