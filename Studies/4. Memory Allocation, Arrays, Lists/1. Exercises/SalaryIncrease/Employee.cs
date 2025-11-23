using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease {
    internal class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            double increase = Salary + (Salary / percentage);
        }
    }
}
