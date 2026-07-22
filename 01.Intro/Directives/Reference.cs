using System;
using System.Collections.Generic;

namespace Directives;

class Reference
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        Console.WriteLine("Count: " + numbers.Count);
    }
}