/** Lab 3.2 */

// Write a C# program to show Operator Overloading
namespace LabThree
{
    class Program
    {
        // Creating Calculator Class
        class Calculator{
            public int Value { get; set;}
            
            // Creating Parameterized Constructor
            public Calculator(int someValue){
                Value = someValue;
            }

            // Overloading the Operator 
            public static Calculator operator +(Calculator obj1, Calculator obj2){
                return new Calculator(obj1.Value + obj2.Value);
            }
        }
        static void Main(string[] args){
            // Creating Two Objects of Calculator Class
            Calculator calc1 = new Calculator(5);
            Calculator calc2 = new Calculator(501);
            // Adding the two objects to achieve the operator overloading
            Calculator res = calc1 + calc2;
            // Printing the output of res object
            Console.WriteLine($"Result is : {res.Value}");
            Console.ReadKey();
        }
    }
}