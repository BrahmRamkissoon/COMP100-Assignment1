// Filename: Program.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 11/10/2015
// Description: COMP100 Assignment 1 Part2
/* Write a short program to ask the user about the validity of a simple statement. The program
** should prompt for the satement ( programmer's choice) and accept the response then display 
** the statement as well as the response to the console. The response should be true or false. For
** this question, y ou must use a variable of type bool to store the reponse data. 
** (4 Marks: Functionality) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prompt;
            bool answer;
            
            Console.WriteLine("Is the sky blue?");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            prompt = Convert.ToInt32(Console.ReadLine());
            if (prompt == 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine($"Is the sky blue? {answer}");

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();
        }
    }
}
