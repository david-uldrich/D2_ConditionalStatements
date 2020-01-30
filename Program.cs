// Programmer: David Uldrich
// Date: 01/28/2020
// Project: C# Grade Calculator
// Description: Assigns a letter grade based on grade value entered
using System;

namespace D2_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Post the message asking for the grade input
            Console.WriteLine("Enter the number grade you expect to get in ISM 4300...");

            // Initiate Try-Catch to validate user inputs
            try
            {
                // Read the grade input value
                string input = Console.ReadLine();

                // Parse the grade input from a string to an integer
                int grade = int.Parse(input);

                // Evaluate the grade input and assign a grade based on the integer. If-else-if condition to create tiers
                if ((grade <= 100) & (grade >= 98))
                {
                    Console.WriteLine("Your grade will be an A+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 97) & (grade >= 92))
                {
                    Console.WriteLine("Your grade will be an A");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 91) & (grade >= 90))
                {
                    Console.WriteLine("Your grade will be a A-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 89) & (grade >= 88))
                {
                    Console.WriteLine("Your grade will be B+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 87) & (grade >= 82))
                {
                    Console.WriteLine("Your grade will be B");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 81) & (grade >= 80))
                {
                    Console.WriteLine("Your grade will be B-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 79) & (grade >= 78))
                {
                    Console.WriteLine("Your grade will be C+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 77) & (grade >= 72))
                {
                    Console.WriteLine("Your grade will be C");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 71) & (grade >= 70))
                {
                    Console.WriteLine("Your grade will be C-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 69) & (grade >= 68))
                {
                    Console.WriteLine("Your grade will be D+");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 67) & (grade >= 62))
                {
                    Console.WriteLine("Your grade will be D");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 61) & (grade >= 60))
                {
                    Console.WriteLine("Your grade will be D-");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade <= 59) & (grade >= 0))
                {
                    Console.WriteLine("Your grade will be F");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter a valid grade. Next time, try entering an integer");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            // Display error message for invalid user inputs
            catch
            {
                Console.WriteLine("Please enter a valid grade. Next time, try entering an integer");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of Try-Catch
        } // End of Main
    } // End of Class
} // End of Namespace
