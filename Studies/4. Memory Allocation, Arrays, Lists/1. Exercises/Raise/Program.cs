using System.Collections.Generic;
using System.ComponentModel;

namespace Raise {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int e = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for(int i = 0; i < e; i++) {
                Console.WriteLine("Employee #" + i + ":");

                Console.Write("Enter employee's id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter employee's name: ");
                string name = Console.ReadLine();

                Console.Write("Enter employee's salary: ");
                double salary = int.Parse(Console.ReadLine());
                Console.WriteLine();

                employee.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee ID that will receive a salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.Write("Enter percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.SalaryIncrease(percentage);

            } else {
                Console.WriteLine("Employee's ID non existant.");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employee) {
                Console.WriteLine(obj);
            }
        }
    }
}
