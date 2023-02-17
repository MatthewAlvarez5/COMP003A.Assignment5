/* 
 *  Author: Matthew Alvarez
 *  Course: COMP-003A
 *  Purpose: Assignment 5 - Looping Structures
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
            
            PrintSeparator("\tTriangle");   //call method PrintSeparator(string)

            /* Triangle Section */
            Console.Write("Enter a positive whole digit: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            string inputString = Convert.ToString(Console.ReadLine());
            
            isoscelesTriangleBuilder(inputString, size);    //Call method
            Console.Write("\n");

            /*Favorite Characters Section*/
            PrintSeparator("   Favorite Characters");   //Call method

            Console.Write("To Generate 5 Characters press (G) OR To Enter Characters and their Birth Years press (E): ");
            string userChoice = Convert.ToString(Console.ReadLine());

            if (userChoice == "G" || userChoice == "g") //generate 5 chosen names for "G" or "g" input
            {
                Console.Write("\n");
                CharacterInfo(1962, "Spider-Man");
                CharacterInfo(1813, "Uncle Sam");
                CharacterInfo(1980, "Harry Potter");
                CharacterInfo(1920, "James Bond");
                CharacterInfo(1854, "Sherlock Holmes");
                Console.Write("\n");
            }
            else if(userChoice == "E" || userChoice == "e") //Enter names for "E" or "e" input
            {
                string userChoice2;
                do  //loop while input is "Y" for each entry
                {
                    Console.Write("Enter a Character Name: ");
                    string userName1 = Console.ReadLine();
                    Console.Write("Enter the Character's Birth Year: ");
                    int birthYear = Convert.ToInt16(Console.ReadLine());
                    CharacterInfo(birthYear, userName1);
                    Console.Write("Continue? (Y/N): ");
                    userChoice2 = Convert.ToString(Console.ReadLine());
                    if(userChoice2 == "Y" || userChoice2 == "y" || userChoice2 == "N" || userChoice2 == "n")
                    {
                        PrintSeparator();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                } while (userChoice2 == "Y" || userChoice2 == "y");
            }
            else 
            { 
                Console.WriteLine("Invalid Input!");
            }

            // End of Code Separator
            PrintSeparator();
            Console.WriteLine("\t\tEnd of Code");
            PrintSeparator();

        }
        
        /// <summary>
        /// Method to Print Line of Characters for Format
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '~'));
        }

        /// <summary>
        /// Method to enter a string to output Title Separator
        /// </summary>
        /// <param name="sectionTitle">String Input</param>
        static void PrintSeparator(string sectionTitle)
        {
            PrintSeparator();
            Console.WriteLine($"\t{sectionTitle} Section");
            PrintSeparator();
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
            for (int i = size-1; i > 0; i--)
            {
                outputString = outputString.Substring(0, i);
                Console.WriteLine(outputString);
            }
        }
        /// <summary>
        /// Method to calculate age based on birth year
        /// </summary>
        /// <param name="birthYear">Input integer</param>
        static int AgeCalculator(int birthYear)
        {
            int age = (DateTime.Now.Year - birthYear);
            return age;
        }
        /// <summary>
        /// Method that receives birth year and name and outputs message
        /// </summary>
        /// <param name="birthYear">integer input</param>
        /// <param name="name">string input</param>
        static void CharacterInfo(int birthYear, string name)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }

    }
}