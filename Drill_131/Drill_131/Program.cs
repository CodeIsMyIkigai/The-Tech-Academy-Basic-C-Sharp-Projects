using System;
using System.Collections.Generic;

namespace Drill_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string> { FirstName = "Chuck", LastName = "Bisquits", Id = 1 };
            List<string> things = new List<string>() { "things", "and", "stuff" };
            emp1.Things = things;

            Employee<int> emp2 = new Employee<int> { FirstName = "Chuck", LastName = "Bisquits", Id = 1 };
            List<int> intThings = new List<int>() { 1,2,3,4,5,6,7,8,9,0 };
            emp2.Things = intThings;

            foreach(string thing in emp1.Things)
            {
                Console.WriteLine("String thing: {0}", thing);
            }

            foreach(int thing in emp2.Things)
            {
                Console.WriteLine("Int thing: {0}", thing);
            }


            Console.ReadLine();//To see the output
        }
    }
}
