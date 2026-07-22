using System;

namespace Directives;

class Program
{
    static void Main()
    {
#pragma warning disable CS0168
        int unusedVariable;
#pragma warning restore CS0168
    }
}