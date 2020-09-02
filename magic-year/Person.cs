using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    public class Person
    {
        private string _firstName;
        private string _surname;
        private decimal _annualSalary;
        private decimal _monthlySalary;
        private int _startYear;
        private int _magicYear;

        public void MagicDetails()
        {
            Console.WriteLine("Welcome to the Magic Year Calculator!\n");
            Console.Write("Enter you first name: ");
            _firstName = Console.ReadLine();
            Console.Write("Enter your surname: ");
            _surname = Console.ReadLine();
            Console.Write("Enter your annual salary: ");
            _annualSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter your work start year: ");
            _startYear = Convert.ToInt32(Console.ReadLine());
            
            _monthlySalary = Math.Round(_annualSalary / 12, MidpointRounding.ToEven);
            _magicYear = (_startYear + 65);
        }

        public void MagicSlip()
        {
            Console.WriteLine("\nYour magic age details are: ");
            Console.WriteLine($"Name: {_firstName} {_surname}");
            Console.WriteLine($"Monthly Salary: {_monthlySalary}");
            Console.WriteLine($"Magic Year: {_magicYear}");
        }
    }
}


