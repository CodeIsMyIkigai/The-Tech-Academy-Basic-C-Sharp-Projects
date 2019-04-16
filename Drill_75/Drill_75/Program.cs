using System;
/*

C# Page 75 Drill

EXERCISE: BOOLEAN LOGIC
Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and return a “true” or “false” at the end as to whether or not the applicant qualified for car insurance.

REQUIREMENTS
Ask the following questions:
- What is your age?
- Have you ever had a DUI?
- How many speeding tickets do you have?

Use the following qualification rules to determine if the applicant qualifies for car insurance:
- Applicants must be over 15 years old.
- Applicants must not have any DUI’s.
- Applicants must not have more than 3 speeding tickets.
- Print the result of the boolean expression created from the above business rules.

*/

namespace Drill_75
{
    class Program
    {

        //Get a valid string result from the console.
        private static int GetConsoleInt(string question, string requestion)
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

        //Get a valid bool result from the console.
        private static bool GetConsoleBool(string question, string requestion)
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


        static void Main(string[] args)
        {

            
            int age = GetConsoleInt("What is your age?", "Please enter a valid integer age.");
            bool hasDUI = GetConsoleBool("Have you ever had a DUI?", "Please enter 'true' or 'false'." );
            int tickets = GetConsoleInt("How many speeding tickets do you have?", 
                "Please enter a valid integer number of tickets.");

            Console.WriteLine("Qualified?");

            bool qualified = (
                    (age > 15) && 
                    !hasDUI && 
                    (tickets < 4)
                );

            Console.WriteLine(qualified);

            Console.ReadLine();

        }
    }
}
