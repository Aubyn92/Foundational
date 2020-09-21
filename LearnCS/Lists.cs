using System;
using System.Collections.Generic;

namespace LearnCS
{
    class Lists
    {
        public void PrimeNumList()
        {
            var primeNumbers = new List<int>();
            int[] array = new int[] { 1, 2, 3 };
            primeNumbers.AddRange(array);
        }
    }
}