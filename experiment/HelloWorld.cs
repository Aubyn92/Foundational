using System;

namespace experiment
{
    class HelloWorld
    {

        // DATA MEMBERS
        private IOutputWriter _output;

        // CONSTRUCTOR:
        public HelloWorld(IOutputWriter output)
        {
            this._output = output;
        }

        // FUNCTION:
        public void Output()
        {
            _output.WriteLine("Hello World!");
        }
    }
}