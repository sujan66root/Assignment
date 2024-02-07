using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for the amount received
            Console.Write("How much did you receive money ($)? ");
            double totalAmount = double.Parse(Console.ReadLine());

            // Calculate three quarters for books and supplies
            double booksAndSupplies = 0.75 * totalAmount;

            // Calculate the remaining amount for coffees, Flash Computer, and subway tickets
            double remainingAmount = 0.25 * totalAmount;
            int coffees = (int)(remainingAmount / 2);
            int flashComputer = (int)(remainingAmount / 4);
            int subwayTickets = (int)(remainingAmount / 3);

            // Calculate the amount remaining for white roses
            double whiteRoses = remainingAmount - (coffees * 2 + flashComputer * 4 + subwayTickets * 3);

            // Display the results
            Console.WriteLine($"Book and Supplies: {booksAndSupplies:C}");
            Console.WriteLine("\nYou can then buy:");
            Console.WriteLine($"{coffees} coffees");
            Console.WriteLine($"{flashComputer} Flash Computer Numbers");
            Console.WriteLine($"{subwayTickets} subway Tickets");
            Console.WriteLine($"and you will have {whiteRoses:C} for the white roses.");
            Console.ReadKey();


        }
    }
}
