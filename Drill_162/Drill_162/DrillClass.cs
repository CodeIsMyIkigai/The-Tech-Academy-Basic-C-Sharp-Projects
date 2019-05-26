using System;
using System.Collections.Generic;
using System.Text;

/*
EXERCISE:
1. Create a const variable

2. Create a variable using the keyword "var".

3. Chain two constructors together.
*/



namespace Drill_162
{
    class DrillClass
    {
        public bool ThisIsCool { get; set; }

        public DrillClass() : this(true)
        {

        }
            
        public DrillClass(bool cool)
        {
            ThisIsCool = cool;
        }
    }
}
