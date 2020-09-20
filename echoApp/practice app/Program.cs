using System;

namespace practice_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new EchoIo(); //making a new console input/output
            var hello = new Echo(console); //making a new echo program and injecting the console dependency from the echo program constructor
            hello.Implement(); //starting the echo program
        }
    }
}