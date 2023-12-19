﻿/* Lab 1.1 */

// Write a C# program to show logical if.. else if

//             Conditions To Meet

// a. If marks >=80 to marks <=100, show A
// b. If marks >=60 to marks <80, show B
// c. If marks >=40 to marks < 60, show C
// d. If marks <40, show F

using System;
namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            //Taking Marks Input From user.
            Console.WriteLine("Enter Your Marks : ");
            marks = Convert.ToInt32(Console.ReadLine());
            // If marks >=80 to marks <=100, show A
            if (marks >= 80 && marks <= 100)
            {
                Console.WriteLine("A");
            }
            // If marks >=60 to marks <80, show B
            else if (marks >= 60 && marks < 80)
            {
                Console.WriteLine("B");
            }
            // If marks >=40 to marks < 60, show C
            else if (marks >= 40 && marks < 60)
            {
                Console.WriteLine("C");
            }
            // If marks <40, show F
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadKey();
        }
    }
}