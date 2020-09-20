using System;

namespace experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            var fancyConsoleWriter = new FancyOutputWriter();
            var hello = new HelloWorld(fancyConsoleWriter);
            hello.Output();
        }
    }
}
