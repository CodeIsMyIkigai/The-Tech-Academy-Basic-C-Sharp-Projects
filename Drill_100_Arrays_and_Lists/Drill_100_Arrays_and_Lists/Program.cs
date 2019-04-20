using System;
using System.Collections.Generic;
using Drill_92;

/*
    C# Drill pg 100

    EXERCISE:

    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
    1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

    2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

    3. Add in a message that displays when the user selects an index that doesn’t exist.

    4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
*/

namespace Drill_100_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays and lists.");
                                 
            //Get the string
            string[] strArray = new string[] { "zero", "one", "two", "three", "four" };
            int index = -1;
            while (index < 0 || index > strArray.Length)
            { 
                index = ConsoleUtil.GetConsoleInt("Enter an integer number between 0 and " + strArray.Length.ToString());
                if (index < 0 || index > strArray.Length)
                {
                    Console.WriteLine("Please enter an integer number between 0 and {0}", strArray.Length);
                }
            }
            Console.WriteLine("The element at {0} is {1}", index, strArray[index]);

            //Get the integer.
            int[] intArray = new int[] { 0, 1, 2, 3, 4 };
            index = -1;
            while (index < 0 || index > intArray.Length)
            {
                index = ConsoleUtil.GetConsoleInt("Enter an integer number between 0 and " + intArray.Length.ToString());

                if(index < 0 || index > intArray.Length)
                {
                    Console.WriteLine("Please enter an integer number between 0 and {0}", intArray.Length);
                }

            }
            Console.WriteLine("The element at {0} is {1}", index, intArray[index]);

            //Get string from List of strings.
            List<string> strList = new List<string> { "zero", "one", "two", "three", "four" };

            Console.WriteLine(strList.Count.ToString());
            
            index = -1;
            while (index < 0 || index > strList.Count) 
            {
                index = ConsoleUtil.GetConsoleInt("Enter an integer number between 0 and " + strList.Count.ToString());
                if (index < 0 || index > strList.Count)
                {
                    Console.WriteLine("Please enter an integer number between 0 and {0}", strList.Count);
                }
            }
            Console.WriteLine("The element at {0} is {1}", index, strList[index]);

            Console.ReadLine();



        }
    }
}
