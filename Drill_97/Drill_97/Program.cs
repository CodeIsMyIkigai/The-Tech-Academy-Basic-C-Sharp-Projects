using System;
using System.Text;

/*
C# Pg 97 Drill

EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1) Concatenate three strings.

2) Convert a string to uppercase.

3) Create a Stringbuilder and build a paragraph of text, one sentence at a time.

Note: Interestingly no output was stipulated :(

*/


namespace Drill_97
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "This is a string";
            string str2 = "This is another string";
            string str3 = "This is yet another string";


            Console.WriteLine("Concatenate three strings for output:");
            Console.WriteLine(str1 + " " + str2 + " " + str3);

            Console.WriteLine("Outputting str1 converted to all uppercase using ToUpper method:");
            Console.WriteLine(str1.ToUpper());  //Note this does not modify the value of str1.

            

            Console.WriteLine("Concatination using StringBuilder to make a paragraph.");
            StringBuilder sb = new StringBuilder(str1);
            sb.Append(".  ");
            sb.Append(str2);
            sb.Append(".  ");
            sb.Append(str3).Append(".");   //Not a syntax I prefer but just trying it here.

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
