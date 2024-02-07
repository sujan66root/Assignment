using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide your age");

            //Get the user's input and save it in an integer variable
            int age = Convert.ToInt32(Console.ReadLine());

            //Calculate the user's birth year
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            //Print the user's calculated birth year
            Console.WriteLine($"Your year of birth is {birthYear}");
            Console.ReadKey();
        }
    }
}
