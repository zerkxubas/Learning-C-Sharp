// Lab 1.3

// Write a C# program to show the multiplication table of given number.

using System;
class Program{
    static void Main(string[] args){
        // Taking User Input For Desired Number
        int userInput;
        Console.WriteLine("Enter A Number To Get Multiplication Table : ");
        userInput = Convert.ToInt32(Console.ReadLine());
        // Now Calculating & Displaying the Multiplication Table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{userInput} * {i} = {userInput*i}");            
        }
    }
}
