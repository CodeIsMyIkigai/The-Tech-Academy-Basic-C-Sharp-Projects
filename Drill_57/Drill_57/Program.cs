using System;
/*
EXERCISE: C# Pg 57 - VARIABLES AND DATA TYPES
Your job is to create a daily report for students of The Tech Academy.

REQUIREMENTS
The program must start by printing “The Tech Academy”.

The next line below that must be “Student Daily Report”

You must ask and save to a well-named variable and proper data type answers to the following questions:

What course are you on?

What page number?

Do you need help with anything? Please answer “true” or “false”.

Were there any positive experiences you’d like to share? Please give specifics.

Is there any other feedback you’d like to provide? Please be specific.

How many hours did you study today?

After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” 

This would be the end of the program.

 */




namespace Drill_57
{
    class Program
    {

        //Get a valid string result from the console.
        private static string getConsoleString(string question, string requestion)
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
        //Get a valid string result from the console.
        private static int getConsoleInt(string question, string requestion)
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
        private static bool getConsoleBool(string question, string requestion)
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
            //Print out Header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n\n");


            //Print out Questionaire

            //Course Name
            string courseName = getConsoleString("What course are you on?",
                "Course name cannot be empty!  Please enter your current course name."
                );

            //Page number?
            int pageNumber = getConsoleInt("What page number?", "Page number must be a valid non-empty integer! Please enter current page number.");

            //Need Help?
            bool needHelp = getConsoleBool("Do you need help with anything? Please answer “true” or “false”.",
                "Answer cannot be empty.  Please enter either “true” or “false”."
                );

            //Posative Experiences
            string posExperiences = getConsoleString("Were there any positive experiences you’d like to share? Please give specifics.",
                "Experiences cannot be empty.  Please give specifics or enter “N/A”."
                );

            //Feedback
            string feedback = getConsoleString("Is there any other feedback you’d like to provide? Please be specific.",
                "Feedback cannot be empty.  Please enter specifics or enter “N/A”."
                );

            //Hours worked
            int hoursStudied = getConsoleInt("How many hours did you study today?", 
                "Hours must be a valid non-empty integer!.  Please enter an integer number of hours you worked today."
                );

            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            //Typically we would do something with this data but the exercise does not have a requirement for that.
            Console.ReadLine(); //Placed this here so instructors can see the output.
        }
    }
}
