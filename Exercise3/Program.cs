using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter values for a and b
            Console.Write("Enter the value of a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            int b = int.Parse(Console.ReadLine());

            // Print the values before swapping
            Console.WriteLine($"Before swapping: a: {a}, b: {b}");

            // Swap the values using a temporary variable
            int temp = a;
            a = b;
            b = temp;

            // Print the values after swapping
            Console.WriteLine($"After swapping: a: {a}, b: {b}");

            Console.ReadKey();
        }
    }
}
