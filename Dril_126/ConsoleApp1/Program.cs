﻿using System;

/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an interface called IQuittable and have it define a void method called Quit().

2. Have your Employee class from the previous drill inherit that interface and implement 
    the Quit() method in any way you choose.

3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
    Hint: an object can be of an interface type if it implements that specific interface.     
     
*/



namespace Drill_126
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable emp1= new Employee() { FirstName = "Example", LastNamed = "Student", Id = 123 };

            Console.WriteLine(emp1.GetType()); // Not sure the requirement was written correctly.

            emp1.Quit();

            Console.ReadLine();//So we can see output.
        }
    }
}
