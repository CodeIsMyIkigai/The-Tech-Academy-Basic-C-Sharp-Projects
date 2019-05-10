using System;

/*
    


    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and 
    then return the answer as an integer.

2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, 
    such as 12. Then display the result to the screen.

3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it
    and then return the answer as an integer.

4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display 
    the result to the screen.

5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a 
    different math operation to it and then return the answer as an integer.

6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates 
    to an integer. Display the result to the screen.
       
 */


namespace Drill_114
{
    class Program
    {
        static void Main(string[] args)
        {
            TehMaths tehMaths = new TehMaths();

            int result;

            //Calling with integer
            result = tehMaths.DoSomeMaths(12);
            Console.WriteLine("The result of calling the int version of the method witht he value 12: {0} ", result);
            //Calling with decimal
            result = tehMaths.DoSomeMaths(12.00m);
            Console.WriteLine("The result of calling the decimal version of the method witht he value 12.00m: {0} ", result);
            //Calling with string
            result = tehMaths.DoSomeMaths("12");
            Console.WriteLine("The result of calling the string version of the method witht he value \"12\": {0} ", result);




            Console.ReadLine();
        }
    }
}
