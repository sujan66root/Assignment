using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;

            Console.Write("Enter a real number: ");
            x = Convert.ToDouble(Console.ReadLine());

            if ((x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2))
            {
                Console.WriteLine($"{x} x belongs to I");
            }
            else
            {
                Console.WriteLine($"{x} x does not belong to I");
            }
            Console.ReadKey();
        }
    }
}
