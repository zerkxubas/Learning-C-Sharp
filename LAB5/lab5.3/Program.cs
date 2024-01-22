/** LAB5.3 */

/*

WAP in LINQ Syntax
    a. First create List of strings with 4 string values
    b. Get and show all string from List with LINQ
    c. Filter and show the list containing the matching string text.

*/
using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>{ "Pragun", "Lokey", "Kancha", "Ramu Dai"};
            
            var items = from something in MyList where something.Contains("a") select something;
            foreach (var item in items)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}