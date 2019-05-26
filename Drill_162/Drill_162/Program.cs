using System;
using System.Collections.Generic;

/*
EXERCISE:
1. Create a const variable

2. Create a variable using the keyword "var".

3. Chain two constructors together. 
*/

namespace Drill_162
{
    class Program
    {

        const string Key = "This Key String";

        static void Main(string[] args)
        {
            var things = new Dictionary<string, DrillClass>();

            DrillClass drill = new DrillClass();
            things[Key] = drill;

            DrillClass thingy = things[Key];

            Console.WriteLine("Things are fine: {0}", thingy.ThisIsCool);
            Console.ReadLine();
        }
    }
}
