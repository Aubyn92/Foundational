using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;


namespace callMe
{
    public class StringTransform
    {
        public string TransformPhoneNumber (string phoneNumber)
        {
            var digitOnlyPhoneNum = Regex.Replace(phoneNumber, "\\D+", "");
            if (digitOnlyPhoneNum.Substring(0, 2) == "61")
            {
                digitOnlyPhoneNum = digitOnlyPhoneNum.Remove(0, 2);
            }
            
            var noBracketNum = digitOnlyPhoneNum.Replace("(", "").Replace(")", "");

            var noDashesAndDots = Regex.Replace(noBracketNum, "[-/.]", "");
           
            var noPlusSign = Regex.Replace(noDashesAndDots, "\"\\\\+\"", "");
            return noPlusSign;
        }
    }
}