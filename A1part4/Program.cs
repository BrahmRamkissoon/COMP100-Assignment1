﻿// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 11/10/2015
// Description: Assignment 1 Part 4
/* Write a program to calculate and display the potential difference between the ends of a wire.
** The program will prompt the user for the current flowing and the resistance of the wire.
** (Potential difference is the product of the current and the resistance of the wire and may 
** include a fractional part). Y ou must accept fractions as the input.
** (3 Marks: Functionality) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1part4
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt;
            double currentFlowing;
            double resistanceInWire;
            double potentialDifference;

            Console.WriteLine("Please enter the current flowing: ");
            prompt = Console.ReadLine();
            currentFlowing = Convert.ToDouble(prompt);


            Console.WriteLine("Please enter the resistance of the wire: ");
            prompt = Console.ReadLine();
            resistanceInWire = Convert.ToDouble(prompt);

            potentialDifference = currentFlowing*resistanceInWire;
            Console.Write($"Potential Difference is: {potentialDifference}");

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();


        }
    }
}
