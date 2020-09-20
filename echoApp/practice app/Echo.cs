using System;

namespace practice_app
{
    public class Echo 
    {
        private readonly IConsoleIo _consoleIo;

        public Echo(IConsoleIo consoleIo) //consoleIo: injecting it here in the constructor for use in implement()
        {
            _consoleIo = consoleIo;
        }

        public void Implement()
        {
            var str = _consoleIo.Input();
            _consoleIo.Output(str);
        }
    }
}