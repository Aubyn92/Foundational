using System;

namespace practice_app
{
    public class EchoIo : IConsoleIo
    {
        public string Input()
        { 
            string line =  Console.ReadLine();
            return line;
        }
        
        public void Output(string args)
        {
            Console.WriteLine(args);
        }
    }
}