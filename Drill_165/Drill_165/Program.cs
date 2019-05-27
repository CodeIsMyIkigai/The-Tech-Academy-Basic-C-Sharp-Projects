using System;

/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask the user for his age.

2. Display the year user born.

3. Exceptions must be handled using "try .. catch".

4. Display appropriate error messages if user enters zero or negative numbers.

5. Display a general message if exception caused by anything else. 
*/

namespace Drill_165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your agejusing digits only.");
                String input = Console.ReadLine();
                int age;
                while (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Please enter your agejusing digits only.");
                    input = Console.ReadLine();
                }
                if (age == 0)
                {
                    throw new ZeroAgeException("You entered an age of 0!");
                }
                if (age < 0)
                {
                    throw new NegativeAgeException("You entered a negative age!");
                }
                Console.WriteLine("Your entered age is {0}.", age);
            }
            catch(ZeroAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NegativeAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine(); //Halt output
            }
        }
    }
}