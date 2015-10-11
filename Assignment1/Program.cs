// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 10/10/2015
// Description: COMP100 Assignment 1 Part 1
/* Write a short program to promp the user to enter a single character. The program should
** display a message like "Your response was y" back to the console. For this question, you must
** use a variable of type char for the character entered
** (3 Marks: Functionality) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1 Part 1
            char prompt;

            Console.Write("Please enter a single character: ");

            prompt = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nYour response was {prompt}");


        }
    }
}
