using System.Collections.Generic;
using System.Data;

namespace SalaryIncrease {
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("How many employees will be registered? ");
            int e = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < e; i++) {
                Console.WriteLine("Employee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have a salary increase: ");
            

            Console.WriteLine("Updated list of employees: ");

        }
    }
}
