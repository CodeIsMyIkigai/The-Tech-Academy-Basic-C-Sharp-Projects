using System;
using System.Collections.Generic;
using System.Text;

/*
 IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

2. In the Main() method, instantiate that class.

3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

4. Create a method with output parameters.

5. Overload a method.

6. Declare a class to be static.
 */


namespace Drill_117
{
    static class Drill_117_Util
    {
        //Requirement of void method with and output parameter.
        public static void DivideByTwo(decimal input, out int output)
        {
            output = (int)(input / 2);
        }

        //Requirements of overloaded method.
        public static void DivideByTwo(string input, out int output)
        {
            decimal dOutput;
            decimal.TryParse(input, out dOutput);
            output = (int)(dOutput / 2);
        }
    }
}
