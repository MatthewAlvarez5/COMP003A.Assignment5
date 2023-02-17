/* 
 *  Author: Matthew Alvarez
 *  Course: COMP-003A
 *  Purpose: Assignment 5 - Looping Structures
 *  just testing GitHub
 */

using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 5";
            PrintSeparator();
            Console.WriteLine("\t\tTriange Section ");
            PrintSeparator();

            Console.Write("Enter a digit: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            string inputString = Convert.ToString(Console.ReadLine());
            
            isoscelesTriangleBuilder(inputString, size);

            PrintSeparator();
            Console.WriteLine("\t   Favorite Character Section ");
            PrintSeparator();

            Console.Write("Enter a character: ");
            string inputName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter their birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{inputName} turns {age} this year!");



        }
        
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '~'));
        }
        /// <summary>
        /// Method to enter a string and return nothing
        /// </summary>
        /// <param name="parameter">String Input</param>
        static void PrintSeparator(string fakeParameter)
        {
            //No output but runs if called with specific parameter type
        }
        /// <summary>
        /// Method to build an Isosceles triangle
        /// </summary>
        /// <param name="inputString">Input String</param>
        /// <param name="size">Input Integer</param>
        static void isoscelesTriangleBuilder(string inputString, int size)
        {
            string outputString = inputString;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(outputString);
                outputString += inputString;
            }
            for (int i = size; i > 0; i--)
            {
                outputString = outputString.Substring(0, i);
                Console.WriteLine(outputString);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="birthYear"></param>
        static int AgeCalculator(int birthYear)
        {
            int age = (2023 - birthYear);
            return age;

        }
    }
}