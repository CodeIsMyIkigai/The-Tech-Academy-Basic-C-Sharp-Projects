using System;
using System.Text;
using System.IO;

/*
 
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask a user for a number.

2. Log that number to a text file.

3. Print the text file back to the user.

    INSTRUCTORS - You might wish to change the logfile path.  Otherwise just look for the file in your user directory.
     
*/



namespace Drill_154
{
    class Program
    {
        

        static void Main(string[] args)
        {            
            try
            {
                string LogFile = @"c:\users\" + Environment.UserName + @"\CMT_Drill_154.log.txt";
                Console.WriteLine("Please enter a number.");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                File.WriteAllText(LogFile, string.Format("The number is {0}.",number));
                string text = File.ReadAllText(LogFile);
                Console.WriteLine(text);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a valid number");
            }
            finally
            {
                Console.ReadLine();//pause output
            }
            
        }
    }
}
