using System;
using System.Collections.Generic;

/*
C# Pg 103
 
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a one-dimensional Array of strings. Ask the user to input some text. 
    Create a loop that goes through each string in the Array, adding the user’s text to the string.    
    Then create a loop that prints off each string in the Array on a separate line.

2. Create an infinite loop.

3. Fix the infinite loop so it will execute.

4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
    Create a loop that iterates through the list and then displays the index of the array that contains matching text on 
    the screen.

7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

8. Add code to that above loop that stops it from executing once a match has been found.

9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to 
   search for in the List. Create a loop that iterates through the list and then displays the indices of the array 
   that contain matching text on the screen.

10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that 
    evaluates each item in the list, and displays a message showing the string and whether or not it has already 
    appeared in the list.
    
*/


namespace Drill_103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oneDimensionalArray = new string[] { "one", "two", "three", "four", "five" };

            Console.Write("Requirement  1 - Input some text: ");
            string inputStr = Console.ReadLine();

            for (int x = 0; x < oneDimensionalArray.Length; x++)
            {
                oneDimensionalArray[x] = oneDimensionalArray[x] + inputStr;
            }

            foreach (string entry in oneDimensionalArray)
            {
                Console.WriteLine(entry);
            }


            Console.WriteLine("\n\nRequirements 2,3 - Infinite Loop");
            Boolean go = true;
            Boolean stupid = true;

            while (go && stupid)
            {
                Console.Write("I go: {0}.", go);
                stupid = false;
                Console.WriteLine("  But am I stupid: {0}", stupid);
            }

            Console.WriteLine("\n\nRequirements 4, 5 - Some iteration tests with < and <= operators.");

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("iterator < 10: {0}", x);
            }
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("iterator <= 10: {0}", x);
            }

            List<string> myList = new List<string> { "one", "two", "three", "four", "five" };

            Console.Write("\n\nRequirement 6, 7, 8 - Enter some text to search for: ");
            inputStr = Console.ReadLine();

            /*
            //For some reason the requirements ask me to make a loop to do what the builtin methods do... insanity :)
            // -- For instance, there are more method calls and variable declarations etc.  And the code is messy.
            // -- Collections should be used how they are intended.
            if (myList.Contains(inputStr))
            {
                Console.WriteLine("Text found at the {0} position.", myList.IndexOf(inputStr));
            }
            else
            {
                Console.WriteLine("Text not found in list.");
            }
            */
            Boolean found = false;
            for(int x = 0; x < myList.Count && !found; x++)
            {
                if(inputStr == myList[x])
                {
                    Console.WriteLine("Text found at the {0} position.", x);
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine("Text not found in list.");
            }
                      

            Console.Write("\n\nRequirement 9, 10 - Enter some text to search for ['three' is the dupe]: ");
            inputStr = Console.ReadLine();

            myList.Add("three"); //Adding a duplicate

            found = false;
            for (int x = 0; x < myList.Count; x++)
            {
                if (inputStr == myList[x])
                {
                    Console.WriteLine("Text found at the {0} position.", x);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Text not found in list.");
            }

            Console.Write("\n\nRequirement 11 - Checking the uniqueness of values in a list");
            

            List<string> lookUp = new List<string>();

            foreach(string key in myList)
            {
                if(!lookUp.Contains(key))
                {
                    Console.WriteLine("'{0}' has not appeared in the list yet.", key);
                    lookUp.Add(key);
                }
                else
                {
                    Console.WriteLine("'{0}' has already appeared in the list.", key);
                }

            }

            Console.Write("\n\nHit enter to exit.");
            Console.ReadLine();
        }
    }
}
