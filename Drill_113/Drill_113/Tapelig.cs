using System;
using System.Collections.Generic;
using System.Text;


/*
Comment: This class is part of the solution for Dril 113 obviously.  The author of the drill stipluates that it might seem odd.  I do.
    The requirements for the class indidate I take to integers.  Do math on one, and display the second to the screen.  I guess
    the result of the math operation is irrelevant as they didn't ask for it...  Also, why didn't they stipulate a static method?
    I'm instantiating a class with no properties to call a method that does nothing to the missing properties in the class.  Odd.

Requirements - 

IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math 
    operation on the first integer and display the second integer to the screen.

2. In the Main() method of the console app, instantiate the class.

3. Call the method in the class, passing in two numbers.

4. Call the method in the class, specifying the parameters by name.
 
*/





namespace Drill_113
{
    class Tapelig
    {

        public void Hjernelose(int dumt, int gal)
        {
            dumt += 100;  //There.. I did a math operation
            Console.WriteLine("Den andre parameteren er {0}", gal);
        }
    }
}
