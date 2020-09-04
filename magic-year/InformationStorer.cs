using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    class InformationStorer
    {
        public string ReadString(string prompt)
        {
            Console.Write(prompt);
            string read = Console.ReadLine();

            while (string.IsNullOrEmpty(read) || (!Regex.IsMatch(read, @"^[a-zA-Z]+$")))
            {
                Console.WriteLine("Invalid input. Input your name again: ");
                read = Console.ReadLine();
            }
            return read;
        }

        public decimal ReadDecimal(string prompt)
        {
            Console.Write(prompt);
            decimal readDec = 0.0M;
            bool success = false;
            while (!success)
            {
                var readDecString = Console.ReadLine();
                success = decimal.TryParse(readDecString, out readDec);
                if (!success)
                {
                    Console.WriteLine("Not a number, please try again: ");
                }
            }
            return readDec;
        }

        public int ReadInt(string prompt)
        {
            Console.Write(prompt);
            int readNum = 0;
            bool success = false;
            while (!success)
            {
                var readNumString = Console.ReadLine();
                success = int.TryParse(readNumString, out readNum);
                if (!success)
                {
                    Console.WriteLine("Not a number, please try again: ");
                }
            }
            return readNum;
        }
    }
}