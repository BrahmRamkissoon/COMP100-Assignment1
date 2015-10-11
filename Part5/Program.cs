// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 11/10/2015
// Description: Assignment 1 Part 5
/* Write a program to promp the user for the amount of adult and child tickets that she needs.
** Adult tickets cost $3.75 and child tickets cost $2.25. The program will display a user-friendly 
** message to the console of the number of tickets purchased as well as the total cost. use the "C"
** format-specifier for currency
** (6 Marks: Functionality) */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main ( string [] args )
        {
            string prompt;
            int numOfAdultTickets;
            int numOfChildTickets;
            double unitPriceOfAdultTickets = 3.75d;
            double unitPriceOfChildTickets = 2.25d;
            double costOfAdultTickets;
            double costOfChildTickets;
            double totalCost;

            Console.WriteLine("++++Ticket Cost Calculator++++");
            Console.Write("Please enter number of Adult tickets to be purchased: ");
            prompt = Console.ReadLine();
            numOfAdultTickets = Convert.ToInt32(prompt);

            Console.Write("Please enter number of child tickets to be purchased: ");
            prompt = Console.ReadLine();
            numOfChildTickets = Convert.ToInt32(prompt);

            costOfAdultTickets = numOfAdultTickets * unitPriceOfAdultTickets;
            costOfChildTickets = numOfChildTickets * unitPriceOfChildTickets;
            totalCost = costOfAdultTickets + costOfChildTickets;

            Console.WriteLine("+++Ticket Purchase Details++++");
            Console.WriteLine($"# Adult Tickets: {numOfAdultTickets}, Cost: {costOfAdultTickets}");
            Console.WriteLine($"# Child Tickets: {numOfChildTickets}, Cost: {costOfChildTickets}");
            Console.WriteLine($"++++++++++++++ Total cost: {totalCost}"  );

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();



        }
    }
}
