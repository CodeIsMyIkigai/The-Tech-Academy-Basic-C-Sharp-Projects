using System;
/*
C# Drill on page 66
EXERCISE: CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:

1. Takes an input from the user, multiplies it by 50, and prints the result to the console. 
    (Note: make sure your code can take inputs larger than 10,000,000).
2. Takes an input from the user, adds 25 to it, and prints the result to the console.
3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
 */

namespace Drill_66
{
    class Program
    {
        //Get valid input from the console.
        private static decimal GetInput()
        {
            decimal result;
            Console.Write("Please input a valid number: ");
            string inputString = Console.ReadLine();
            while(!decimal.TryParse(inputString, out result))
            {
                Console.Write("Please input a valid number: ");
                inputString = Console.ReadLine();                    
            }
            return result;
        }

        static void Main(string[] args)
        {
            decimal total;
            decimal input;

            //Requirement 1: multiply by 50
            input = GetInput();
            total = 50 * input;
            Console.WriteLine(" 50 x {0} is: {1}", input, total);

            //Requirement 2: add 25
            input = GetInput();
            total = 25 + input;
            Console.WriteLine(" 25 + {0} is: {1}", input, total);

            //Requirement 3: divide by 12.5
            input = GetInput();            
            total = input / 12.5m;
            Console.WriteLine(" {0} / 12.5 is: {1}", input, total);

            //Requirement 4: input greater than 50
            input = GetInput();            
            Console.WriteLine(" {0} is > 50: {1}", input, (input > 50));

            //Requirement 5: divide by 7 give remainder
            input = GetInput();
            total = input % 7;
            Console.WriteLine(" Remainder of {0} / 7  is: {1}", input, total);

            Console.ReadLine(); //For instructor convenience.
        }
    }
}
