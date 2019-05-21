using System;

/*
 EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an enum for the days of the week.

2. Prompt the user to enter the current day of the week.

3. Assign the value to a variable of that enum data type you just created.

4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

NOTE: I kinda have an issue with this requirement as I believe it's less useful than the TryParse method.  We should
be learning all the API yes?
     
     */


namespace Drill_134
{
    class Program
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday, 
            Friday,
            Saturday,
            Sunday
        }
        /*
         * Rather than a try catch block, I would have liked to use a method like below to get the data and ensure its
         * validity.  Its unlikely that any of the code below would cause an exception and I like the TryParse
         * pattern in C# very much.  (Yes, I/O and Memory exceptions can happen... but parsing issues are less likely
         * with the TryParse pattern.
         */
        public static DayOfWeek GetDayOfWeek()
        {
            DayOfWeek result;
            
            Console.WriteLine("Pleas enter the current day of the week.");
            String input = Console.ReadLine();

            while (!Enum.TryParse(input, true, out result))  //loop until you get valid input
            {
                Console.WriteLine("Please enter an actual day of the week.");
                input = Console.ReadLine();
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pleas enter the current day of the week.");
                String input = Console.ReadLine();
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);                
                Console.WriteLine("Day of the week entered: {0}", day);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine(); //To see the Output
            }
        }
    }
}
