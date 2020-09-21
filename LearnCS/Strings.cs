using System;

namespace LearnCS
{
    class Strings
    {
        public void NameFormatting()
        {
            string firstName = "John";
            string lastName = "Doe";
            int age = 27;
            string sentence = String.Format("{0} {1} is {2} years old.", firstName, lastName, age);
        }
    }
}