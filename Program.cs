/*
    Author: Jesse Schmitt
    Date: 1/30/2020
    Comments: This is my deliverble 2 conditional statement
 */
 
using System;

namespace Deliverable2_ConditionalStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what grade they expect to get
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            // Try block to validate user input
            try
            {
                // Gather user input
                string input = Console.ReadLine();
                // This variable will be the grade the user expects
                decimal grade = decimal.Parse(input);
                // This IF/ELSE IF/ELSE statement will be used to give grade
                if ((grade <= 100) & (grade >= 98))
                {
                    Console.WriteLine("Your grade is A+!");
                }
                else if ((grade <= 97) & (grade >= 92))
                {
                    Console.WriteLine("Your grade is A!");
                }
                else if ((grade <= 91) & (grade >= 90))
                {
                    Console.WriteLine("Your grade is A-");
                }
                else if ((grade <= 89) & (grade >= 88))
                {
                    Console.WriteLine("Your grade is B+");
                }
                else if ((grade <= 87) & (grade >= 82))
                {
                    Console.WriteLine("Your grade is B");
                }
                else if ((grade <= 81) & (grade >= 80))
                {
                    Console.WriteLine("Your grade is B-");
                }
                else if ((grade <= 79) & (grade >= 78))
                {
                    Console.WriteLine("Your grade is C+");
                }
                else if ((grade <= 77) & (grade >= 72))
                {
                    Console.WriteLine("Your grade is C");
                }
                else if ((grade <= 71) & (grade >= 70))
                {
                    Console.WriteLine("Your grade is C-");
                }
                else if ((grade <= 69) & (grade >= 68))
                {
                    Console.WriteLine("Your grade is D+");
                }
                else if ((grade <= 67) & (grade >= 62))
                {
                    Console.WriteLine("Your grade is D");
                }
                else if ((grade <= 61) & (grade >= 60))
                {
                    Console.WriteLine("Your grade is D-");
                }
                else if ((grade <= 59) & (grade >= 0))
                {
                    Console.WriteLine("Your grade is F");
                }
                else

                    Console.WriteLine("Invaild Entry!");
                
            }
            catch
            {
                Console.WriteLine("Please enter a valid grade");
            }
        }
    }
}
