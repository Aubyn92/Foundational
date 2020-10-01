using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace callMe
{
    public class StringTransform
    {
        public string TransformPhoneNumber (string phoneNumber)
        {
            try
            {
                return Regex.Replace(phoneNumber, @"[\\s\\-()]", "");
                // return Regex.Replace(phoneNumber,@"[^1?[\s-]?\(?(\d{3})\)?[\s-]?\d{3}[\s-]?\d{4}]", "");
                // return Regex.Replace(phoneNumber, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5)).Trim();
            }
            catch (RegexMatchTimeoutException)
            {
                return "";
            }
            // return Regex.Replace(phoneNumber, @"[^\w\s\D]", "");
            // return Regex.Replace(phoneNumber,@"[^1?[\s-]?\(?(\d{3})\)?[\s-]?\d{3}[\s-]?\d{4}]", "");
            // return Regex.Replace(phoneNumber, @"[^()\\s-]+", "").Trim();
        }
    }
}