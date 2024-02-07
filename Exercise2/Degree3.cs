using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Degree3
    {
        static void Main(string[] args)
        {
            // Prompt the user to input values for coefficients a, b, c, and variable x
            Console.WriteLine("Enter a (int): ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b (int): ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c (int): ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x (double): ");
            double x = double.Parse(Console.ReadLine());

            // Calculate intermediate values to simplify the expression
            // Intermediate variable ab represents the average of a and b
            double ab = (a + b) / 2.0;

            // Intermediate variable abSquared represents the square of the sum of a and b
            double abSquared = Math.Pow(a + b, 2);

            // Evaluate the polynomial using the simplified expression
            double result = ab * x * x * x + abSquared * x * x + a + b + c;

            // Display the result of the polynomial evaluation
            Console.WriteLine($"The value of polynomial is {result}");
            Console.ReadKey();


        }
    }

}
