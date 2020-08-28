using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ABC
{
    class Program
    {
        // main method:
        public static void Main() 
        {
            // creating the object:
            string blocks = "BO XK DQ CP NA GT RE TG QD FS JW HU VI AN OB ER FS LY PC ZM"; //the sample blocks given
            // create a list for the sample words named 'words', using keyword 'new' and invoke it
            List<string> words = new List<string>()
            {
                "A", "BARK", "BOOK", "TREAT", "COMMON", "SQUAD", "CONFUSE"
            };
            Alphabet blockobj = new Alphabet(blocks, words); 
            blockobj.ABC();
        }
    }
}
