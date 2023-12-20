// Lab 3.1
/**
    Create a class “Employee” with following specs:

    a. - Field Members : firstName, lastName, salary
    b. - Properties : FirstName, LastName, Salary
    c. - Methods : ShowFullName, IncrementSalary(double s)
    d. - Constructor : Employee(__ , ___ , ___)
    e. Now, create object of Employee(“Ram”, “Bahadur”, 20000)
    f. Show Employee Fullname & Salary
    g. - Change FirstName to “Hari” & increment salary by 5000
    h. - Show full name & salary
*/
using System;
namespace LabThree
{
    // Creating Employee Class.
    class Employee{
        // Properties : FirstName, LastName, Salary
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public double Salary{ get; set; }
        public Employee(string fName, string lName, double salary){
            FirstName = fName;
            LastName = lName;
            Salary = salary;
        }
        // Methods to ShowFullName
        public string ShowFullName(){
            return $"{FirstName} {LastName}";
        }

        // Methods to IncrementSalary
        public void IncrementSalary(double s){
            Salary += s;
        }   

    }
    class Program{
        static void Main(string[] args){
            Employee emp = new Employee("Ram", "Bahadur", 20000);
            Console.WriteLine($"{emp.ShowFullName()} and {emp.Salary}");
            // Changing the FirstName & Incrementing Salary only.
            emp.FirstName="Hari";
            emp.IncrementSalary(5000);
            Console.WriteLine($"{emp.ShowFullName()} and {emp.Salary}");
            Console.ReadKey();
        }
    }
}