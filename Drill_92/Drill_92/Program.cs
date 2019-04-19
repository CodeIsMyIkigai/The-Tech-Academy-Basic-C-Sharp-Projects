using System;

/*

C# Pg 92
 
EXERCISE: BRANCHING
Your job is to create a console-based application for getting a shipping quote for a package.

REQUIREMENTS
- Dimensions
    - Weight
        - The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
        - The user must then be prompted for the package weight.

    - If the weight is greater than 50, display the error message, 
    “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.

    - Width
        - The user must then be prompted for the package width.
    - Height
        - Then the package height.
    - Length
        - Then the package length.

- Dimension Check
    - If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

- Quote
    - The sum total of dimensions are then multiplied by the weight and divided by 100.
        - The result of that calculation is the quote.
        - Display the quote to the user as a dollar amount.

*/



namespace Drill_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            float weight = ConsoleUtil.GetConsoleFloat(
                "Please enter a valid decimal number for package weght.",
                "Please enter a valid decimal number."
                );
            if(weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }
                        
            float width = ConsoleUtil.GetConsoleFloat(
                "Please enter a valid decimal number for package width.",
                "Please enter a valid decimal number."
                );
            float height = ConsoleUtil.GetConsoleFloat(
                "Please enter a valid decimal number for package height.",
                "Please enter a valid decimal number."
                );
            float length = ConsoleUtil.GetConsoleFloat(
                "Please enter a valid decimal number for length height.",
                "Please enter a valid decimal number."
                );
            float sum = (width + height + length);
            if ( sum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            float estimate = (sum * weight / 100);

            Console.WriteLine("Your estimated total for shipping this package is: {0:C2}", estimate);
            Console.ReadLine();
        }
    }
}
