using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    public class InformationStorer
    {
        private readonly IUserContentInterface _userContentIo;
        
        public InformationStorer (IUserContentInterface userContentIo)
        {
            _userContentIo = userContentIo;
        }

        public string ReadString(string prompt)
        { 
            _userContentIo.WriteLine(prompt);
        string read = _userContentIo.ReadLine();
        
            while (string.IsNullOrEmpty(read) || (!Regex.IsMatch(read, @"^[a-zA-Z]+$")))
        {
            _userContentIo.WriteLine("Invalid input. Input your name again: ");
            read = _userContentIo.ReadLine();
        }
        return read;
        }

        public decimal ReadDecimal(string prompt)
        {
            _userContentIo.WriteLine(prompt);
            decimal readDec = 0.0M;
            bool success = false;
            while (!success)
            {
                var readDecString = _userContentIo.ReadLine();
                success = decimal.TryParse(readDecString, out readDec);
                if (!success)
                {
                    _userContentIo.WriteLine("Not a number, please try again: ");
                }
            }
            return readDec;
        }

        public int ReadInt(string prompt)
        {
            _userContentIo.WriteLine(prompt);
            int readNum = 0;
            bool success = false;
            while (!success)
            {
                var readNumString = _userContentIo.ReadLine();
                success = int.TryParse(readNumString, out readNum);
                if (!success)
                {
                    _userContentIo.WriteLine("Not a number, please try again: ");
                }
            }
            return readNum;
        }
    }
}