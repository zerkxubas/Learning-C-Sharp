/* Lab 1.1*/

// Write a C# program to get numeric input in two variables and calculate the sum.
using System;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking Two Inputs
            Console.WriteLine("Enter The First Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The First Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            // Calculating the Sum & Printing Output.
            Console.WriteLine("The Sum is {0}", firstNumber+secondNumber);
            Console.ReadKey();
        }
    }
}
