using System;

namespace magic_year
{
    public class UserContentIo :IUserContentInterface
    {
        public string ReadLine()
        {
            string prompt =  Console.ReadLine();
            return prompt;
        }
        
        public void WriteLine(string args)
        {
            Console.WriteLine(args);
        }
    }
}