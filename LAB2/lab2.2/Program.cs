/** Lab 2.2 */
// Write a program to show function overloading in C#

using System;

namespace Lab2
{
    class Program
    {
        // Overloaded method for adding integers
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method for adding doubles
        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int intResult = Add(8, 5);
            double doubleResult = Add(4.3, 6.26);

            Console.WriteLine($"Sum of integers: {intResult}");
            Console.WriteLine($"Sum of doubles: {doubleResult}");
        }
    }
}