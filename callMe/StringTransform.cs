using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace callMe
{
    public class StringTransform
    {
        public string TransformPhoneNumber (string phoneNumber)
        {
            return Regex.Replace(phoneNumber, @"[^\w\s\D]", "");
            // return Regex.Replace(phoneNumber, @"[/^\(?(?:\+?61|0)(?:(?:2\)?[ -]?(?:3[ -]?[38]|[46-9][ -]?[0-9]|5[ -]?[0-35-9])|3\)?(?:4[ -]?[0-57-9]|[57-9][ -]?[0-9]|6[ -]?[1-67])|7\)?[ -]?(?:[2-4][ -]?[0-9]|5[ -]?[2-7]|7[ -]?6)|8\)?[ -]?(?:5[ -]?[1-4]|6[ -]?[0-8]|[7-9][ -]?[0-9]))(?:[ -]?[0-9]){6}|4\)?[ -]?(?:(?:[01][ -]?[0-9]|2[ -]?[0-57-9]|3[ -]?[1-9]|4[ -]?[7-9]|5[ -]?[018])[ -]?[0-9]|3[ -]?0[ -]?[0-5])(?:[ -]?[0-9]){5})$/]");
            return Regex.Replace(phoneNumber, @"[^[0-9]{10}$", " ");
        }
    }
}