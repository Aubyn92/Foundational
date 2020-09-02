using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace magic_year
{
    class Program
    {
        static void Main()
        {
            var person1 = new Person();
            person1.MagicDetails();
            person1.MagicSlip();
        }
    }
}  