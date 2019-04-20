using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_92
{
    class ConsoleUtil
    {
        /* Get a string from the console */

        //Get a valid string result from the console with two questions.
        public static string GetConsoleString(string question, string requestion)
        {
            Console.WriteLine(question);
            string result = Console.ReadLine();
            while (string.IsNullOrEmpty(result))
            {
                Console.WriteLine(requestion);
                result = Console.ReadLine();
            }
            return result;
        }
        //Get a valid string result from the console with question only.
        public static string GetConsoleString(string question)
        {
            string result = GetConsoleString(question, "Please enter a valid non-empty string.");
            return result;
        }
        //Get a valid string result from the console with no questions.
        public static string GetConsoleString()
        {
            string result = GetConsoleString("Please enter a valid non-empty string.", "Please enter a valid non-empty string.");
            return result;
        }


        /* Get an int from the console */

        //Get a valid string result from the console with question and response.
        public static int GetConsoleInt(string question, string requestion)
        {
            int result;
            Console.WriteLine(question);
            string intIn = Console.ReadLine();
            while (!int.TryParse(intIn, out result))
            {
                Console.WriteLine(requestion);
                intIn = Console.ReadLine();
            }
            return result;
        }

        //Get a valid string result from the console with only question.
        public static int GetConsoleInt(string question)
        {
            int result = GetConsoleInt(question, "Please enter a valid integer.");            
            return result;
        }

        //Get a valid string result from the console with no questions.
        public static int GetConsoleInt()
        {
            int result = GetConsoleInt("Please enter a valid integer.", "Please enter a valid integer.");
            return result;
        }

        /* Get an float from the console */

        //Get a valid float result from the console with question and response.
        public static float GetConsoleFloat(string question, string requestion)
        {            
            float result;
            Console.WriteLine(question);
            string floatIn = Console.ReadLine();
            while (!float.TryParse(floatIn, out result))
            {
                Console.WriteLine(requestion);
                floatIn = Console.ReadLine();
            }
            return result;
        }

        //Get a valid float result from the console with only question.
        public static float GetConsoleFloat(string question)
        {
            float result = GetConsoleFloat(question, "Please enter a valid decimal number.");
            return result;
        }

        //Get a valid string result from the console with no questions.
        public static float GetConsoleFloat()
        {
            float result = GetConsoleFloat("Please enter a valid decimal number.", "Please enter a valid decimal number.");
            return result;
        }

        /* Get a boolean from the console */

        //Get a valid bool result from the console.
        public static bool GetConsoleBool(string question, string requestion)
        {
            bool result;
            Console.WriteLine(question);
            string helpNeeded = Console.ReadLine();
            while (!Boolean.TryParse(helpNeeded, out result))
            {
                Console.WriteLine(requestion);
                helpNeeded = Console.ReadLine();
            }
            return result;
        }
        
        //Get a valid bool result from the console.
        public static bool GetConsoleBool(string question)
        {
            bool result = GetConsoleBool(question, "Please enter either 'true' or 'false'.");
            return result;
        }

        //Get a valid bool result from the console.
        public static bool GetConsoleBool()
        {
            bool result = GetConsoleBool("Please enter either 'true' or 'false'.", "Please enter either 'true' or 'false'.");
            return result;
        }
    }
}
