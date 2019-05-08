using System;


/*

EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
    The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

2. In the Main() program, ask the user what number they want to do the math operations on.

3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.


 */


namespace Drill_111
{
    class Program
    {
        public static int GetIntInput()
        {
            Console.WriteLine("Please enter an integer value");
            string input = Console.ReadLine();
            int output;
            while(!int.TryParse(input, out output))
            {
                Console.WriteLine("Please enter a valid integer number value.");
                input = Console.ReadLine();
            }

            return output;
        }



        static void Main(string[] args)
        {
            int userInput = GetIntInput();

            Console.WriteLine("Going to call AddSix to {0}", userInput);
            Console.WriteLine("Results: {0}", Bizarre.AddSix(userInput));
            Console.WriteLine("Calling SubtractTwo to {0}", userInput);
            Console.WriteLine("Results: {0}", Bizarre.SubtractTwo(userInput));
            Console.WriteLine("Calling Double to {0}", userInput);
            Console.WriteLine("Results: {0}", Bizarre.Double(userInput));




            Console.ReadLine();
        }
    }
}
