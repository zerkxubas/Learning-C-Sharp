/** LAB 5.1 */

// Write a program to show use of Collection and Generics with ArrayList and List.
using System;
using System.Collections.Generic;
using System.Collections;

namespace Lab5{
    class Program
    {
        static void Main(string[] args)
        {
            // Using List (generic)
            List<int> MyList = new List<int>();
            MyList.Add(4);
            MyList.Add(14);
            MyList.Add(44);
            MyList.Add(24);

            Console.WriteLine($"Printing the GenericList\n");

            // Displaying the list.
            foreach(int item in MyList)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPrinting the ArrayList\n");

            // Using ArrayList (non generic)
            ArrayList DemoArrList = new ArrayList();
            DemoArrList.Add("This is a string");
            DemoArrList.Add(true);
            DemoArrList.Add(10.5);
            DemoArrList.Add(100);

            // Displaying the ArrayLists.
            foreach (var item in DemoArrList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}