using System;
/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

2. In the Main() method, create an object of data type Number and assign an amount to it.

3. Print this amount to the console.
     
     
     
*/

namespace Drill_137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number();
            myNumber.Amount = 127.54m;
            Console.WriteLine("Amount is: {0}", myNumber.Amount);
            Console.ReadLine(); //Keep output on screen.
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }

}
