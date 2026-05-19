using System.Collections.Generic;
using System.Globalization;

namespace Company {
    class Program {
        static void Main(string[] args) {
            string searchId; int employeeQty; string name; decimal salary, percentage; List<Employees> employees = new List<Employees>();
            do {
                Console.Write("How many employees will be registered? ");
                employeeQty = int.Parse(Console.ReadLine());

                if(employeeQty <= 0) {
                    Console.WriteLine("The quantity of employees must be greater than zero.");
                }
            } while(employeeQty <= 0);

            for(int i = 1;i <= employeeQty;i++) {
                Console.WriteLine($"Employee #{i}:");

                do {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    if(name.Any(char.IsSymbol) || name.Any(char.IsDigit) || string.IsNullOrEmpty(name)) {
                        Console.WriteLine("The name cannot be empty or contain digits/symbols.");
                    }
                } while(name.Any(char.IsSymbol) || name.Any(char.IsDigit) || string.IsNullOrEmpty(name));

                do {
                    Console.Write("Salary: ");
                    salary = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    if(salary < 1000) {
                        Console.WriteLine("The Salary must be at least 1000");
                    }
                } while(salary < 1000);

                employees.Add(new Employees(name,salary));
            }

            Console.WriteLine("List of employees: ");
            foreach(Employees employee in employees) {
                Console.WriteLine(employee);
            }

            do {
                Console.Write("Enter the employee id that will have salary increase: ");
                searchId = Console.ReadLine();

                if(string.IsNullOrEmpty(searchId)) {
                    Console.WriteLine("An ID is required to increase the salary.");
                }

                if(!employees.Exists(x => x.Id == searchId)) {
                    Console.WriteLine("This ID does not exist!");
                }
            } while(string.IsNullOrEmpty(searchId) || !employees.Exists(x => x.Id == searchId));

            Employees employeeIncreaseSalary = employees.Find(employee => employee.Id == searchId);

            do {
                Console.Write("Enter the percentage: ");
                percentage = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(percentage <= 0) {
                    Console.WriteLine("The percentage must be greater than zero");
                }
            } while(percentage <= 0);

            employeeIncreaseSalary.IncreaseSalary(percentage);

            Console.WriteLine("Updated list of employees: ");
            foreach(Employees employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}