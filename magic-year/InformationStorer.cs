using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    // CLASS NAME
    public class InformationStorer : IUserContentInterface
    {
        // CONSTRUCTOR
        public InformationStorer (IUserContentInterface informationStorer)
        {
            this.informationStorer = informationStorer;
        }

        // INTERFACE IMPLEMENTED
        // void WriteLine(string prompt)
        // {
            // informationStorer.WriteLine();
        // }
        
        // perhaps a private func for inout validation
        // public at top, private at bottom
        
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