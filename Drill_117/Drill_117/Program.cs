using System;

/*

IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
    1. Create a class. In that class, create a void method that outputs an integer. 
        Have the method divide the data passed to it by 2.

    2. In the Main() method, instantiate that class.

    3. Have the user enter a number. Call the method on that number. Display the output to the screen. 
        It should be the entered number, divided by two.

    4. Create a method with output parameters.

    5. Overload a method.

    6. Declare a class to be static.   
     
*/

namespace Drill_117
{
    class Program
    {
        static void Main(string[] args)
        {


            bool good = false;
            decimal dInput = 0.00m;
            string input;
            while(!good)
            {
                Console.WriteLine("Enter a number.");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out dInput))
                {
                    good = true;
                }
            }

            Drill_117_Util.DivideByTwo(dInput, out int output);
            Console.WriteLine("Result of dividing {0} by 2 is {1}", dInput, output);

            string twelve = "12";

            Drill_117_Util.DivideByTwo(twelve, out output);
            Console.WriteLine("Result of dividing {0} by 2 is {1}", twelve, output);

            Console.ReadLine();
        }
    }
}
