using System;

/*
EXERCISE:

IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
     
     
*/


namespace Drill_129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee() { FirstName = "Instructor", LastName = "Ben", Id = 1 };
            Employee two = new Employee() { FirstName = "Instructor", LastName = "Jan", Id = 2 };
            Employee three = new Employee() { FirstName = "Instructor", LastName = "Jan", Id = 2 };

            if (one == two)
            {
                Console.WriteLine("If this prints then operator overloading failed!!");
            }
            else
            {
                Console.WriteLine("Employees are not equal by Id!");

            }   
            
            if( two == three)
            {
                Console.WriteLine("Employees are equal by Id!");
            }

            Console.ReadLine(); //need so see the output
        }
    }
}
