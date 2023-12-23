/** Lab 4.1 */

// Write a program to show Inheritance in C#.
using System;

namespace LabFour
{
    // Creating Parent Class
    class Shape
    {
        public int length;
        public void Message()
        {
            Console.WriteLine("This is a message from Shape or 'parent' class.");
        }
    }

    // Creating Child Class
    class Square : Shape
    {
        // Child class can inherits the parent class variables, properties & methods.
        public int Area(int len)
        {
            length = len;
            return length*length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Object Of Parent Class 'Shape'
            Shape parent = new Shape();

            // Printing The Parent Class Method 'Message'
            parent.Message();

            // Now Creating Another Object Of Child Class 'Square' which inherits the Shape Class.
            Square child = new Square();

            // child object can also access the parent class methods.
            child.Message();

            // Printing The Child Class Method 'Area'
            Console.WriteLine($"The area of square is {child.Area(5)}");
            Console.ReadKey();
        }
    }
}
