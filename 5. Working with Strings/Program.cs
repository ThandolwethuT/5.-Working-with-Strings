using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");

            string firstName = "Anele";
            string lastName = "Thombela";
            Console.WriteLine(firstName + " " + lastName);  

            Console.WriteLine(lastName.Length);

            Console.WriteLine(firstName.ToUpper());

            Console.WriteLine(lastName.Contains("Fu"));

            Console.WriteLine(firstName[0]);

            Console.WriteLine("index of a is ");
            Console.WriteLine(lastName.IndexOf('a'));

            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.Substring(1,2));
            Console.Read();


        }
    }
}
