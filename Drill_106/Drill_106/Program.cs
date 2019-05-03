﻿using System;
using System.Collections.Generic;

/*

EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a list of integers.  Ask the user for a number to divide each number in the list by.
   Write a loop that takes each integer in the list, divides it by the number the user entered, 
   and displays the result to the screen.

2. Run that code, entering in non-zero numbers as the user.Look at the displayed results.

3. Run that code, entering in zero as the number to divide by. Note any error messages you get.

4. Run that code, entering in a string as the number to divide by.Note any error messages you get.

5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program 
   display a message to the display to let you know the program has emerged from the try/catch block 
   and continued on with program execution.In the catch block, display the error message to the screen.
   Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper 
   error messages display on the screen, and that the code after the try/catch block gets executed.

*/


namespace Drill_106
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Please enter an integer number: ");
            try
            {
                string input = Console.ReadLine();
                double number = double.Parse(input);

                Console.WriteLine(number);

                Console.ReadLine();

                foreach (int num in numberList)
                {
                    double result = num / number;
                    Console.WriteLine("{0} divided by {1} is equal to {2}", num, number, result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }   
            
            Console.WriteLine("\n\nAfter the Try/Catch block.");
            Console.ReadLine();
        }
    }
}
