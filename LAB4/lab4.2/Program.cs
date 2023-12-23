/** Lab 4.2*/

// Program to show use of interface and multiple inheritance in C#
using System;

namespace LabFour
{
    // Creating Interface 'Shape'
    interface Shape
    {
        int Area();
    }

    // Creating another Interface 'Color'
    interface Color
    {
        string GetColor();
    }

    // Now Creating a Class Which inherits both Shape & Color interface
    class Rectangle : Shape, Color
    {
        private int length, breadth;
        private string colorName;

        // Creating Parameterized constructor.
        public Rectangle(int len, int br, string color)
        {
            this.length = len;
            this.breadth = br;
            this.colorName = color;
        }

        // reusing the two different interface methods for multi inheritance.
        public int Area()
        {
            return this.length * this.breadth;
        }

        public string GetColor()
        {
            return colorName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Rectangle class object
            Rectangle rect = new Rectangle(10, 25, "Yellow");
            Console.WriteLine($"The area of the rectangle is : {rect.Area()}");
            Console.WriteLine($"The Color of the rectangle is : {rect.GetColor()}");
            Console.ReadKey();
        }
    }
}