using System;

namespace LearnCS
{
    class ForLoops
    {
        public void Loop()
        {
            string x = "Hi";
            int n = 10;

            for (int i = 0; i <= 10; i++)
            {
                if (n == 10)
                {
                    break;
                }

                Console.WriteLine(x);

            }
        }
    }
}