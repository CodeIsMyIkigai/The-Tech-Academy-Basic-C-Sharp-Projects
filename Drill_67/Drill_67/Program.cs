using System;
/*
EXERCISE: MATH AND COMPARISON OPERATORS
Your job is to create an anonymous income comparison program.

REQUIREMENTS
The program must start by printing “Anonymous Income Comparison Program” to the screen.

It must then print “Person 1” to the screen and get the following details:

Hourly Rate

Hours worked per week

It must then print “Person 2” to the screen and then get the following details:

Hourly rate

Hours worked per week

It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.

It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.

It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it. 

*/





namespace Drill_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\n");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate");
            decimal personOneHourlyRate = GetValidNumber();
                       
            Console.WriteLine("Hours worked per week");
            decimal personOneHoursPerWeek = GetValidNumber();

            Console.WriteLine("\n\nPerson 2");

            Console.WriteLine("Hourly Rate");
            decimal personTwoHourlyRate = GetValidNumber();
            
            Console.WriteLine("Hours worked per week");
            decimal personTwoHoursPerWeek = GetValidNumber();

            decimal personOneAnnualSalary = personOneHourlyRate * personOneHoursPerWeek * 52;
            decimal personTwoAnnualSalary = personTwoHourlyRate * personTwoHoursPerWeek * 52;

            Console.WriteLine("\n\nAnnual salary of Person 1:");
            Console.WriteLine(personOneAnnualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(personTwoAnnualSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool oneIsBigger = personOneAnnualSalary.CompareTo(personTwoAnnualSalary) == 1;

            Console.WriteLine(oneIsBigger);

            Console.ReadLine();
            
        }

        //Get a valid decimal result from the console.
        private static decimal GetValidNumber()
        {
            decimal result;            
            string inputString = Console.ReadLine();
            while (!decimal.TryParse(inputString, out result))
            {
                Console.WriteLine("Please enter a valid number.");
                inputString = Console.ReadLine();
            }
            return result;
        }




        
    }
}
