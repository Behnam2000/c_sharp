// Conditional Compilation with Preprocessor Directives
#define DEBUG
using System;

namespace Directives;

class Preprocessor
{
    static void Main(string[] args)
    {
        #if DEBUG
        Console.WriteLine("Debug mode is enabled");
        #else
        Consolw.WriteLine("Debug mode is disabled");
        #endif

    }
}
