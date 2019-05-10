using System;

/*

IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
Have the method do a math operation and return a integer result.

2. In the Main() method of the console app, instantiate the class.

3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

4. Call the method in the class, passing in the one or two numbers entered.

5. Try various combinations of numbers on the code, including having no second number. 
     
     
*/




namespace Drill_115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer numbers.  The second is optional and you can just enter nothing to proceed with the default[0]");

            string input = Console.ReadLine();
            decimal.TryParse(input, out decimal first);

            input = Console.ReadLine();
            
            decimal.TryParse(input, out decimal second);

            OptionalExample optEx = new OptionalExample();

            int result = optEx.OptionalMath((int)first, (int)second);

            Console.WriteLine("Result: {0}", result);


            Console.ReadLine(); //To see the results before the screen closes.
        }
    }
}
