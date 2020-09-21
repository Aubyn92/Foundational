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
                var userContentIo = new UserContentIo();
                var informationAsker = new InformationAsker();
                var personalData = informationAsker.MagicDetails(userContentIo);
                var informationOutput = new InformationOutput();
                informationOutput.MagicSlip(personalData, userContentIo);
            }
        }
    }