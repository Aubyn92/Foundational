using System;
using System.Collections.Generic;

namespace LearnCS
{
    class Lists
    {
        public void PrimeNumList()
        {
            List<int> primeNumbers = new List<int>();
            int[] array = new int[] { 2, 3, 5, 7, 11 };
            primeNumbers.AddRange(array);
        }
    }
}