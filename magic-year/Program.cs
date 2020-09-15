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
                var informationAsker = new InformationAsker();
                var personalData = informationAsker.MagicDetails();
                var informationOutput = new InformationOutput();
                informationOutput.MagicSlip(personalData);
                // InformationStorer informationStorer = new InformationStorer();
            }
        }
    }