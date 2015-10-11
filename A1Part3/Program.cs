// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 11/10/2015
// Description: COMP100 Assignment 1 Part 3
/* Write a short program to calculate the area of a circle. The user will enter the radius of the
** circle and the program will calculate the area according to the formula (area = 3.14 * radius * radius).
** The result will be displayed to the console. You must accept fractions as the input.
** (3 Marks: Functionality)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt;
            double radius;
            double PI = 3.14d;
            double area;

            Console.WriteLine("++++Area of Circle calculator++++");
            Console.Write("Please enter the radius of your circle: ");
            prompt = Console.ReadLine();

            radius = Convert.ToDouble(prompt);

            area = PI * radius * radius;

            Console.WriteLine($"Area of circle is: {area}");

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();


        }
    }
}
