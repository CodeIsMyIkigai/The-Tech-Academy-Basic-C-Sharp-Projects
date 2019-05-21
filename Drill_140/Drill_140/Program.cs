using System;
using System.Collections.Generic;
using System.Linq;



/*
 
EXERCISE
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. In the Main() method, create a list of at least 10 employees. Each employee should 
    have a first and last name, as well as an Id. At least two employees should have 
    the first name "Joe".

2. Using a foreach loop, create a new list of all employees with the first name "Joe".

3. Do the same thing again, but this time with a lambda expression.

4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
   
Note the comparison of time (not the most accurate method but I did not want to make the perfmon classes for this drill.
 - No surprise the for statement is faster as there is parsing for the lambda method as well as additional method calls.
 - Also no surprise the lambda method usage was much cleaner code.
 - Summary: For small lists like this the difference was trivial, so the cleaner code is better for maintainability.
            However, for large lists.. performance issues might be involved.
     
*/



namespace Drill_140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "LName", Id = 1 });
            employees.Add(new Employee() { FirstName = "Jud", LastName = "LName", Id = 2 });
            employees.Add(new Employee() { FirstName = "Jon", LastName = "LName", Id = 3 });
            employees.Add(new Employee() { FirstName = "Jay", LastName = "LName", Id = 4 });
            employees.Add(new Employee() { FirstName = "Jan", LastName = "LName", Id = 5 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "LName", Id = 6 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "LName", Id = 7 });
            employees.Add(new Employee() { FirstName = "John", LastName = "LName", Id = 8 });
            employees.Add(new Employee() { FirstName = "Jed", LastName = "LName", Id = 9 });
            employees.Add(new Employee() { FirstName = "Job", LastName = "LName", Id = 10 });
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Employee emp;
            watch.Stop();
            watch.Reset();
            watch.Start();

            List<Employee> templist;

            for (int t = 0; t < 10000; t++)  //Looped 10K times to make it measurable.
            {
                templist = new List<Employee>(); //Both loops have this instantiation.
                
                for (int x = 0; x < employees.Count; x++)
                {
                    emp = employees[x];
                    if (emp.FirstName == "Joe")
                    {
                        templist.Add(emp);
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("For-Loop elapsed MS: {0:d}", watch.ElapsedMilliseconds);

            watch.Reset();
            watch.Start();
            for (int t = 0; t < 10000; t++) //Looped 10K as above.
            {
                templist = new List<Employee>();//Same instantiation.
                templist = employees.Where(x => x.FirstName == "Joe").ToList();
            }

            watch.Stop();
            Console.WriteLine("Where elapsed MS: {0:d}", watch.ElapsedMilliseconds);
                                 
            Console.WriteLine("\n\n");
            templist = employees.Where(x => x.Id > 5).ToList();
            foreach(Employee emp1 in templist)
            {
                Console.WriteLine("Name:{0}", emp1.FirstName);
            }

            Console.ReadLine();//Pause the screen for reading output.
        }
    }
}
