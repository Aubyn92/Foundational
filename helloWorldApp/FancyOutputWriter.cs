using System;

namespace experiment
{
    class FancyOutputWriter : IOutputWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine("__" + line + "__");
        }
    }
}