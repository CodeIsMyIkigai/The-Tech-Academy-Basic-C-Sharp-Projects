using System;

/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Prints the current date and time to the console.

2. Asks the user for a number.

3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
     
 */

namespace Drill_156
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                DateTime now = DateTime.Now;
                DateTime result = now + new TimeSpan(number, 0, 0);
                Console.WriteLine("It's currently {0}, in {1} hours it will be {2}", now, number, result);

            }
            catch (Exception)
            {
                Console.WriteLine("Enter a proper number.");                
            }
            finally
            {
                Console.ReadLine(); //Pause output
            }
        }
    }
}
