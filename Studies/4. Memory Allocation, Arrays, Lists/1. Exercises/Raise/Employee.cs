using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Raise
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Name + ", "
                   + Id + ", "
                   + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
