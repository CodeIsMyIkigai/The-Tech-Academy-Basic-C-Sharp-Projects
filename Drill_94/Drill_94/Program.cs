using System;

/*
C# Drill on pg 94

EXERCISE:

    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
    1. Do a boolean comparison using a while statement.
    2. Do a boolean comparison using a do while statement.
*/


namespace Drill_94
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            Console.WriteLine("While loop.");
            while (++counter < 21)
            {
                Console.WriteLine("While: {0:d}", counter);
            }
            counter = 1;
            Console.WriteLine("Do/While loop.");
            do
            {
                Console.WriteLine("Do: {0:d}", counter);
            } while (++counter < 21);
            Console.ReadLine();
        }
    }
}
