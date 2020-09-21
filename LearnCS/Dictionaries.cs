using System;
using System.Collections.Generic;

namespace LearnCS
{
    class Dictionaries
    {
        public void FruitDictionary()
        {
            var inventory = new Dictionary<string, long>();
            inventory.Add("apple", 3);
            inventory.Add("orange", 5);
            inventory.Add("banana", 2);
        }
    }
}