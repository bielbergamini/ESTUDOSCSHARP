using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }



        public Employee(int id, string name, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;

        }

        public void IncreaseSalary(int percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

    

   
}
